import { HttpClient, HttpParams, HttpHeaders, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { DummyProblems, SuperGroups, Groups, SubGroups, RemedyProblems, BrandDto, RouteProblemDto, SocialMediaDto, ProductBaseDto, ActiveIngredientDto, SupplierDto, ViewBrandsDto, Province, ContactDto, EntryDto, EntryAttributesDto, EntryRange, MediaDto, UserDto, UserDtoWithToken, Credentials, LoggedUserInfo, ReturnOnlyString, EntryForDisplayDto, DeleteByIdDto, RemedyForDisplayDto, EntryDetailsForSeoDto, resetPasswordDto, ProblemDetailsForSeoDto, pdfDTO, ProblemForDisplayDto, EditPostDto, EntryRouteDto, Languages, PreviousBatch } from './shared.models';
import { environment } from 'environments/environment';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable()
export class SharedService {
    constructor(private httpClient: HttpClient) {

    }

    connectionstring = environment.apiUrl;

    // Dummy
    public getDummyProblems(): Array<any> {
        return [
            { id: 5, problem: 'Cattle - Beef' },
            { id: 6, problem: 'Cattle - Dairy' },
            { id: 7, problem: 'Game' },
            { id: 8, problem: 'Fruit' },
            { id: 9, problem: 'Sheep' },
            { id: 10, problem: 'Swine' },
            { id: 11, problem: 'Tree Crops' },
        ]
    }

    // Account
    UserDetail: Credentials;
    public login(username: string, password: string): Observable<UserDtoWithToken> {
        this.UserDetail = {
            userName: username,
            password: password
        }
        const headers = new HttpHeaders()
            .append('Content-Type', 'application/json')
            .append('Access-Control-Allow-Methods', '*');
        return this.httpClient.post(this.connectionstring + 'api/auth/token', this.UserDetail, { headers }).pipe(
            map((res: any) => res)
        );
    }
    public register(T: UserDto): Observable<UserDtoWithToken> {
        // console.log(T);
        const headers = new HttpHeaders()
            .append('Content-Type', 'application/json')
            .append('Access-Control-Allow-Methods', '*');
        return this.httpClient.post(this.connectionstring + 'api/auth/register', T, { headers }).pipe(map((res: any) => res));
    }

    forgotPassword(username: string) {
        return this.httpClient.get(this.connectionstring + 'api/auth/forgotpassword/' + `${username}` ).pipe(map((res: any) => res));
    }
    resetPassword(T: resetPasswordDto){
        return this.httpClient.post(this.connectionstring + 'api/auth/resetPassword/', T ).pipe(map((res: any) => res));
    }
    public isLoggedIn(): boolean {
        const myRole = localStorage.getItem('loggedIn');
        if (myRole == undefined || myRole == '') {
            return false;
        } else {
            return true;
        }
    }

    loggedUser: LoggedUserInfo;
    public getLoggedUserDetails() {
        if (localStorage.getItem('access_token') == undefined || localStorage.getItem('access_token') == ''){
            this.loggedUser = {
                token: localStorage.getItem('access_token'),
                firstname: localStorage.getItem('firstname'),
                lastname: localStorage.getItem('lastname'),
                role: '',
                id: localStorage.getItem('id')
            };
            return this.loggedUser;
        }else{
            const helper = new JwtHelperService();
            const decodedToken = helper.decodeToken(localStorage.getItem('access_token'));
            this.loggedUser = {
                token: localStorage.getItem('access_token'),
                firstname: localStorage.getItem('firstname'),
                lastname: localStorage.getItem('lastname'),
                role: decodedToken.role,
                id: localStorage.getItem('id')
            };
            return this.loggedUser;
        }
    }

    public clearLocalStorage() {
        localStorage.clear();
    }

    public isInRole(pRole: string): boolean {
        if( localStorage.getItem('access_token') == undefined || localStorage.getItem('access_token') == ''){
            return false;
        }else{
            const thisUser = this.getLoggedUserDetails();
            if (thisUser.role == 'admin') {
                return true;
            } else {
                return false;
            }
        }
    }

    // Get JSON Countries
   
    // Problems And Solutions
    public getSuperGroups(): Observable<Array<SuperGroups>> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/supergroup', {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getGroups(id: any): Observable<Array<Groups>> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/group/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getSubGroups(id: any): Observable<Array<SubGroups>> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/subgroup/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getProblemsFromRoute(supergroup: any, group: any, subgroup: any): Observable<Array<RouteProblemDto>> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/problems/' + `${supergroup}` + '/'
            + `${group}` + '/' + `${subgroup}`, {
                headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
              }).pipe(map((res: any) => res));
    }
    public getProblemBase(problemBaseId: any): Observable<RouteProblemDto> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/problembase/' + `${problemBaseId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getProblemBaseSeo(supergroup: string, group: string, subgroup: string, problemname: string): Observable<RouteProblemDto> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/problembase/' + `${supergroup}` + 
        '/' + `${group}` + '/' + `${subgroup}` + '/' + `${problemname}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getProblemBaseImages(problemBaseId: any): Observable<Array<string>> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/problembase/images/' + `${problemBaseId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getLanguages(): Observable<Array<Languages>> {
        return this.httpClient.get(this.connectionstring + 'socialmedia/GetLangauges', {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public addSuperGroupInformation(desc: any): Observable<number> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/add/supergroup/' + `${desc}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public addGroupInformation(desc: any, SuperGroupId: any): Observable<number> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/add/group/' + `${desc}` + '/' + `${SuperGroupId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public addSubGroupInformation(desc: any, SuperGroupId: any, GroupId: any): Observable<number> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/add/subgroup/' + `${desc}` + '/' + `${SuperGroupId}` + '/' + `${GroupId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public deleteSuperGroupInformation(id: any) {
        return this.httpClient.delete(this.connectionstring + 'problemandsolution/delete/supergroup/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public deleteSubGroupInformation(id: any) {
        return this.httpClient.delete(this.connectionstring + 'problemandsolution/delete/subgroup/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public deleteGroupInformation(id: any) {
        return this.httpClient.delete(this.connectionstring + 'problemandsolution/delete/group/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getAllRemedies(brandid: number): Observable<Array<ProductBaseDto>> {
        return this.httpClient.get(this.connectionstring + 'remedies/all/' + `${brandid}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getRemedies(problemBaseId: any): Observable<Array<ProductBaseDto>> {
        return this.httpClient.get(this.connectionstring + 'remedies/' + `${problemBaseId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getRemedy(id: any): Observable<ProductBaseDto> {
        return this.httpClient.get(this.connectionstring + 'remedies/byid/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getRemedyProblems(productbaseId: any): Observable<Array<RemedyProblems>> {
        return this.httpClient.get(this.connectionstring + 'remedies/problems/' + `${productbaseId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getActiveIngredient(productId: any): Observable<Array<ActiveIngredientDto>> {
        return this.httpClient.get(this.connectionstring + 'remedies/activeingredient/' + `${productId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getBrand(id: any): Observable<BrandDto> {
        return this.httpClient.get(this.connectionstring + 'remedies/brand/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public getCatagories(): Observable<Array<Groups>> {
        return this.httpClient.get(this.connectionstring + 'socialmedia/getallcatagories', {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public getRemediesForDisplay(): Observable<Array<RemedyForDisplayDto>> {
        return this.httpClient.get(this.connectionstring + 'remedies/remediesfordisplay', {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getProblemForDisplay(): Observable<Array<ProblemForDisplayDto>> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/problemfordisplay/admin', {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getProblemForDisplayAmount(amount: number): Observable<Array<ProblemForDisplayDto>> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/problemfordisplay/admin/' + `${amount}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getLatestRemediesForDisplay(amount: any): Observable<Array<RemedyForDisplayDto>> {
        return this.httpClient.get(this.connectionstring + 'remedies/remediesfordisplay/' + `${amount}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public uploadRemedy(data: File): Observable<ReturnOnlyString> {
        const formData = new FormData();
        formData.append('upload', data);
        const params = new HttpParams();
        const options = {
            params: params,
            reportProgress: false,
        };
        const req = new HttpRequest('POST', this.connectionstring + 'remedies/upload/remedy', formData);
        return this.httpClient.post(this.connectionstring + 'remedies/upload/remedy', formData, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public uploadProblem(data: File): Observable<ReturnOnlyString> {
        const formData = new FormData();
        formData.append('upload', data);
        const params = new HttpParams();
        const options = {
            params: params,
            reportProgress: false,
        };
        const req = new HttpRequest('POST', this.connectionstring + 'problemandsolution/upload/problem', formData);
        return this.httpClient.post(this.connectionstring + 'problemandsolution/upload/problem', formData, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public deleteRemedies(T: DeleteByIdDto): Observable<boolean> {
        return this.httpClient.post(this.connectionstring + 'remedies/delete', T, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(
            map((res: any) => res)
        );
    }
    public deleteMedia(id: number): Observable<any> {
        return this.httpClient.get(this.connectionstring + 'socialmedia/deletepost/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(
            map((res: any) => res)
        );
    }

    public deleteProblems(T: DeleteByIdDto): Observable<boolean> {
        return this.httpClient.post(this.connectionstring + 'problemandsolution/delete', T, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(
            map((res: any) => res)
        );
    }
    public notifyEnquireRemedies(T: ProductBaseDto): Observable<any> {
        let temp = localStorage.getItem('username');
        return this.httpClient.post(this.connectionstring + 'api/auth/notifyenquire/remedy/' + `${temp}`, T, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(
            map((res: any) => res)
        );
    }
    public notifyEnquireProductAndService(brand: string, entry: string, brandid: number): Observable<any> {
        let temp = localStorage.getItem('username');
        return this.httpClient.get(this.connectionstring + 'api/auth/notifyenquire/productandservice/' + `${temp}`
        + '/' + `${brand}` + '/' + `${entry}` + '/' + `${brandid}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(
            map((res: any) => res)
        );
    }
    public getProblemDetailsforseo(problemId: any): Observable<ProblemDetailsForSeoDto> {
        return this.httpClient.get(this.connectionstring + 'problemandsolution/problembasedetailsforseo/' + `${problemId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    // Product and Services
    public getSuperGroupsCommercial(): Observable<Array<SuperGroups>> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/supergroup', {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public getGroupsCommercial(id: any): Observable<Array<Groups>> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/groups/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public getSubGroupsCommercial(superGroupId: any, GroupId: any): Observable<Array<SubGroups>> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/subgroups/' + `${superGroupId}` + '/' 
        + `${GroupId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public getEntries(supergroup: any, group: any, subgroup: any): Observable<Array<EntryDto>> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/entries/' + `${supergroup}` + '/' + `${group}`
            + '/' + `${subgroup}`, {
                headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
              }).pipe(map((res: any) => res));
    }
    public searchProducts(term: string): Observable<Array<EntryDto>> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/entries/search/' + `${term}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getEntryRoute(id: number): Observable<EntryRouteDto> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/getentryroute/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getAllEntries(brandid: number): Observable<Array<EntryDto>> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/entries/all/' + `${brandid}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public getAllBrands(): Observable<Array<BrandDto>> {
        return this.httpClient.get(this.connectionstring + 'brand/brands/all', {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public getEntryDetailsforseo(entryId: any): Observable<EntryDetailsForSeoDto> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/entrydetailsforseo/' + `${entryId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public GetEntryAttributesByName(productname: any): Observable<Array<EntryAttributesDto>> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/getentryattributesbyname/' + `${productname}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public getEntryAttributes(id: any): Observable<Array<EntryAttributesDto>> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/entryattributes/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public getEntriesByRange(range: string): Observable<Array<EntryRange>> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/entriesbyrange/' + `${range}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public addSuperGroupCommercial(desc: any): Observable<number> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/add/supergroup/' + `${desc}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public addGroupCommercial(desc: any, SuperGroupId: any): Observable<number> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/add/group/' + `${desc}` + '/' + `${SuperGroupId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public addSubGroupCommercial(desc: any, SuperGroupId: any, GroupId: any): Observable<number> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/add/subgroup/' + `${desc}` + '/' + `${SuperGroupId}` + '/' + `${GroupId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public deleteSuperGroup(id: any) {
        return this.httpClient.delete(this.connectionstring + 'productsandservice/delete/supergroup/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public deleteSubGroup(id: any) {
        return this.httpClient.delete(this.connectionstring + 'productsandservice/delete/subgroup/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public deleteGroup(id: any) {
        return this.httpClient.delete(this.connectionstring + 'productsandservice/delete/group/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public uploadEntry(data: File): Observable<ReturnOnlyString> {
        const formData = new FormData();
        formData.append('upload', data);
        const params = new HttpParams();
        const options = {
            params: params,
            reportProgress: false,
        };
        const req = new HttpRequest('POST', this.connectionstring + 'productsandservice/upload/entry', formData);
        return this.httpClient.post(this.connectionstring + 'productsandservice/upload/entry', formData, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public getEntryForDisplay(): Observable<Array<EntryForDisplayDto>> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/entriesfordisplay', {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public getLatestUploadEntryForDisplay(amount: any): Observable<Array<EntryForDisplayDto>> {
        return this.httpClient.get(this.connectionstring + 'productsandservice/entriesfordisplay/lastupload/' + `${amount}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(
            map((res: any) => res)
        );
    }
    public deleteEntry(id: any): Observable<boolean> {
        return this.httpClient.delete(this.connectionstring + 'productsandservice/entry/delete/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(
            map((res: any) => res)
        );
    }
    public deleteEntries(T: DeleteByIdDto): Observable<boolean> {
        return this.httpClient.post(this.connectionstring + 'productsandservice/entries/delete', T, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(
            map((res: any) => res)
        );
    }
    // Social Media
    // If you pass in a 0 the latest 10 posts will be returned....
    public getSocialMediaNextBatch(lastId: any, userId: any, languageId: any, T: PreviousBatch): Observable<Array<MediaDto>> {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.post(this.connectionstring + 'socialmedia/nextbatch/' + `${lastId}` + '/' + `${currentUser.id}`
        + '/' + `${languageId}`, T, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public searchMedia(term: any): Observable<Array<MediaDto>> {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.get(this.connectionstring + 'socialmedia/search/' + `${term}` + '/' + `${currentUser.id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public searchProductMedia(term: any): Observable<Array<MediaDto>> {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.get(this.connectionstring + 'socialmedia/searchProductMedia/' + `${term}` + '/' + `${currentUser.id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    
    public getMediaWithVideo(): Observable<Array<MediaDto>> {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.get(this.connectionstring + 'socialmedia/videomedia/' + `${currentUser.id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getMediaWithArticle(): Observable<Array<MediaDto>> {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.get(this.connectionstring + 'socialmedia/articlemedia/' + `${currentUser.id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public postEntryPDF(T: pdfDTO): Observable<any> {
        // console.log(T);
        return this.httpClient.post(this.connectionstring + 'socialmedia/postEntryPDF', T, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public postProductBasePDF(T: pdfDTO): Observable<any> {
        +T.id;
        // console.log(T);
        return this.httpClient.post(this.connectionstring + 'socialmedia/postProductBasePDFfile', T, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public deleteEntryPDF(id: number): Observable<any> {
        return this.httpClient.get(this.connectionstring + 'socialmedia/deleteEntryPdf/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public deleteProductBasePDF(id: number): Observable<any> {
        return this.httpClient.get(this.connectionstring + 'socialmedia/deleteProductBasePdf/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public postSocialMediaToServer(T: SocialMediaDto): Observable<any> {
        return this.httpClient.post(this.connectionstring + 'socialmedia/postmedia', T, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public editPost(T: EditPostDto, id: number): Observable<any> {
        return this.httpClient.post(this.connectionstring + 'socialmedia/editpost/' + `${id}`, T, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public deleteImage(id: number): Observable<any> {
        return this.httpClient.get(this.connectionstring + 'socialmedia/removeImage/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public likePost(postId: any, userId: any): any {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.get(this.connectionstring + 'socialmedia/like/' + `${currentUser.id}` + '/' + `${postId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public addComment(postId: number, userId: number, comment: string): any {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.get(this.connectionstring + 'socialmedia/addcomment/' + `${postId}` + '/' + `${currentUser.id}` + '/' + `${comment}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public UnlikePost(postId: any, userId: any): any {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.get(this.connectionstring + 'socialmedia/unlike/' + `${currentUser.id}` + '/' + `${postId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getMediaById(id: any, userId: any): Observable<MediaDto> {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.get(this.connectionstring + 'socialmedia/byid/' + `${id}` + '/' + `${currentUser.id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getMediaByRemedy(productbaseid: any): Observable<Array<MediaDto>> {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.get(this.connectionstring + 'socialmedia/byRemedy/' + `${productbaseid}` + '/' + `${currentUser.id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getMediaByProduct(entryid: any): Observable<Array<MediaDto>> {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.get(this.connectionstring + 'socialmedia/byProduct/' + `${entryid}` + '/' + `${currentUser.id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getMediaByCatagory(catagoryid: any): Observable<Array<MediaDto>> {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.get(this.connectionstring + 'socialmedia/byCatagory/' + `${catagoryid}` + '/' + `${currentUser.id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getMediaByIdWithComments(id: any, userId: any): Observable<MediaDto> {
        const currentUser = this.getLoggedUserDetails();
        return this.httpClient.get(this.connectionstring + 'socialmedia/byidwithcomments/' + `${id}` + '/' + `${currentUser.id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    //Supplier
    public getSupplier(id: any): Observable<SupplierDto> {
        return this.httpClient.get(this.connectionstring + 'supplier/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getSuppliersByBrand(brandId: any): Observable<Array<SupplierDto>> {
        return this.httpClient.get(this.connectionstring + 'supplier/bybrand/' + `${brandId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getSupplierBrands(supplierId: any): Observable<Array<ViewBrandsDto>> {
        return this.httpClient.get(this.connectionstring + 'supplier/brands/' + `${supplierId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
    public getProvinces(): Observable<Array<Province>> {
        return this.httpClient.get(this.connectionstring + 'supplier/province', {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    //Brand
    public getBrandWithImage(id: any): Observable<BrandDto> {
        return this.httpClient.get(this.connectionstring + 'brand/' + `${id}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }

    public getBrandContact(contactId: any): Observable<ContactDto> {
        return this.httpClient.get(this.connectionstring + 'brand/contact/' + `${contactId}`, {
            headers: new HttpHeaders().set('Authorization', `Bearer ${localStorage.getItem('access_token')}`)
          }).pipe(map((res: any) => res));
    }
}

