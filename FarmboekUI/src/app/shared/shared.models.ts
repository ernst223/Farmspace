export interface Dummy {
    id: number;
    userName: string;
    password: string;
}

export class DummyProblems {
    id: number;
    problem: string;
}

export class Problems {
    id: number;
    problem: string;
}

   export class RootObject {
    countries: Country[];
  }
  
  export class Country {
    name: string;
    code: string;
  }

export class ProductBaseDto {
    productBaseId: number;
    name: string;
    information: string;
    formulation: string;
    registration: string;
    concentration: string;
    entryTypeId: number;
    brandId: number;
    range: string;
    brandProductDisplay: boolean;
    imageLink: string;
}

export class RemedyProblems {
    routeId: number;
    problemBaseId: number;
    description: string;
}

export class Languages {
    id: number;
    language: string;
}
export class EntryRouteDto {
    superGroup: string;
    group: string;
    subGroup: string;
    brand: string;
    productName: string;
}

export class PreviousBatch {
    mediaId: number[];
}

export class EntryDto {
    entryId: number;
    name: string;
    isBrowseBy: boolean;
    isInfo: boolean;
    brandId: number;
    brand: string;
    entryTypeTemplateId: number;
    range: string;
    imageLink: string;
}

export class EntryRange {
    entryId: number;
    range: string;
    entryName: string;
}

export class EntryAttributesDto {
    entryAttributeId: number;
    attribute: string;
    value: string;
    brandId: number;
    imageLink: string;
    entryName: string;
    entryRange: string;
}

export class SupplierDto {
    supplierId: number;
    supplierName: string;
    supplierDesc: string;
    supplierAddress1: string;
    supplierAddress2: string;
    supplierCity: string;
    provinceId: number;
    countryId: number;
    supplierPostCode: string;
    supplierTel1: string;
    supplierTel2: string;
    accountNo: string;
    isActive: boolean;
    hasPaid: boolean;
    imageName: string;
}

export class Province {
    provinceId: number;
    countryId: number;
    provinceName: string;
    provinceCode: string;
}

export class ViewBrandsDto {
    brandId: number;
    brandName: string;
    imageLink: string;
}

export class ActiveIngredientDto {
    activeIngredientId: number;
    code: string;
    name: string;
}

export class BrandDto {
    brandId: number;
    name: string;
    description: string;
    summary: string;
    address: string;
    contactId: number;
    accountNo: string;
    isActive: boolean;
    hasPaid: boolean;
    imageName: string;
}
export class TempBrandHolder {
    id: number;
    name: string;
}
export class ContactDto {
    contactId: number;
    fullName: string;
    telNumber: string;
    cellNumber: string;
    email: string;
    website: string;
}
export class MediaDto {
    mediaId: number;
    description: string;
    title: string;
    url: string;  // Old Data uses this 
    isActive: boolean;
    imageUrl: string; // Old Data uses this
    webLink: string;
    youtubeLink: string;
    mediaDate: Date;
    likeStatus: boolean;
    likeCount: string;
    shareCount: string;
    commentCount: string;
    mediaComments: MediaCommentDto[];
}

export class RemedyForDisplayDto {
    productBaseId: number;
    productName: string;
    formulation: string;
    concentration: string;
    registration: string;
    brandId: number;
    brand: string;
    range: string;
}
export class resetPasswordDto {
    username: string;
    password: string;
    token: string;
}
export class EntryDetailsForSeoDto {
    id: number;
    supergroup: string;
    group: string;
    subgroup: string;
    brand: string;
    productName: string;
}

export class ProblemDetailsForSeoDto {
    problemBaseId: number;
    supergroup: string;
    group: string;
    subgroup: string;
    problemname: string;
}
export class UserDto {
    userName: string;
    firstName: string;
    lastName: string;
    password: string;
    cellNumber: string;
    email: string;
    idNumber: string;
    role: string;
    country: string;
    languages: number[];
}

export class Credentials {
    userName: string;
    password: string;
}

export class LoggedUserInfo {
    token: string;
    firstname: string;
    lastname: string;
    role: string;
    id: string;
}
export class UserDtoWithToken {
    id: string;
    token: string;
    userName: string;
    firstName: string;
    lastName: string;
    password: string;
    cellNumber: string;
    email: string;
    idNumber: string;
    role: string;
}
export class ReturnOnlyString {
    myString: string;
    amountOfUploads: number;
}

export class DeleteByIdDto {
    id: number[];
}
export class EntryForDisplayDto {
    entryId: number;
    name: string;
    brandId: number;
    brandName: string;
    range: string;
    entryAttributes: EntryAttributesForDisplayDto[];
}
export class EntryAttributesForDisplayDto {
    entryAttributeId: number;
    key: string;
    value: string;
}
export class MediaCommentDto {
    commentId: number;
    commentDate: Date;
    theComment: string;
    userId: string;
    userName: string;
}

export class FinalProblem {
    id: number;
    problem: string;
    imageLink: string;
}

export class ImageForDisplay {
    image: string;
    thumbImage: string;
}

export class RouteProblemDto {
    problemBaseId: number;
    name: string;
    information: string;
    symptoms: string;
    morbidity: string;
    epidemiology: string;
    entryTypeId: number;
    imageLink: string;
}

export class pdfDTO {
    thePDF: string;
    thePDFName: string;
    id: number;
}

export class ProblemForDisplayDto {
    problemBaseId: number;
    name: string;
    information: string;
    symptoms: string;
    morbidiy: string;
    epidemiology: string;
}

export class EditPostDto {
    title: string;
    description: string;
    newImage: string;
    fileName: string;
}

export class SocialMediaDto {
    id: number;
    title: string;
    description: string;
    mediaDate: Date;
    webLink: string;
    youtubeLink: string;
    theImage: string;
    theImageName: string;
    brandId: number;
    mediaCatagories: MediaCatagoriesDto[];
    mediaProducts: MediaProductLinkDto[];
    mediaRemedies: MediaRemediesLinkDto[];
    Languages: number[];
    hideImage: boolean;
}

export class MediaCatagoriesDto {
    id: number;
    mediaId: number;
    catagoryId: number;
}

export class MediaProductLinkDto {
    id: number;
    mediaId: number;
    entryId: number;
}

export class MediaRemediesLinkDto {
    id: number;
    mediaId: number;
    productBaseId: number;
}
export class SuperGroups {
    id: number;
    superGroupId: number;
    superGroupName: string;
    superGroupDesc: string;
    isCommercial: boolean;
    isInformation: boolean;
}

export class Groups {
    id: number;
    groupId: number;
    groupName: string;
    groupDesc: string;
    isCommercial: boolean;
    isInformation: boolean;
}

export class SubGroups {
    id: number;
    subGroupId: number;
    subGroupName: string;
    subGroupDesc: string;
    isCommercial: boolean;
    isInformation: boolean;
}
