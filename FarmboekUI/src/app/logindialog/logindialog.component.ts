import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA, MatSnackBar } from '@angular/material';
import { Router } from '@angular/router';
import { SharedService } from 'app/shared/shared.service';
import { UserDtoWithToken } from 'app/shared/shared.models';
import { JwtHelperService } from "@auth0/angular-jwt";

@Component({
  selector: 'app-logindialog',
  templateUrl: './logindialog.component.html',
  styleUrls: ['./logindialog.component.scss']
})
export class LogindialogComponent implements OnInit {

  theUser: UserDtoWithToken;
  username = '';
  password = '';
  constructor(public dialogRef: MatDialogRef<LogindialogComponent>, public snackBar: MatSnackBar, public router: Router, private service: SharedService) { }

  ngOnInit() {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  register() {
    this.router.navigate(['/register']);
    this.dialogRef.close();
  }

  forgotPassword() {
    // console.log('Navigating to forgot password');
    this.router.navigate((['/forgotpassword']));
    this.dialogRef.close();
  }

  login() {
    this.service.login(this.username, this.password).subscribe(a => {
      if(a.id != undefined){
        this.theUser = a;
        localStorage.setItem('access_token', this.theUser.token);
        localStorage.setItem('firstname', this.theUser.firstName);
        localStorage.setItem('lastname', this.theUser.lastName);
        localStorage.setItem('id', this.theUser.id);
        localStorage.setItem('username', this.username);
        localStorage.setItem('loggedIn', 'true');
        this.snackBar.open('Welcome ' + this.theUser.firstName, '',{ duration: 4500, }).afterDismissed().subscribe(() => {});
        this.dialogRef.close();
        const helper = new JwtHelperService();
        const decodedToken = helper.decodeToken(this.theUser.token);
      }else{
        this.snackBar.open('Incorrect details', '',{ duration: 2000, }).afterDismissed().subscribe(() => {});
      }
    });
  }
}
