import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material';
import { SharedService } from 'app/shared/shared.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-forgotpassword',
  templateUrl: './forgotpassword.component.html',
  styleUrls: ['./forgotpassword.component.scss']
})
export class ForgotpasswordComponent implements OnInit {

  username = '';
  constructor(private snackBar: MatSnackBar, private service: SharedService, private router: Router) { }

  ngOnInit() {
  }

  resetPassword(){
    if (this.username == undefined) {
      this.snackBar.open('Please enter your email address', '',{ duration: 4500, }).afterDismissed().subscribe(() => {});
    } else {
      this.service.forgotPassword(this.username).subscribe(a => {
        this.snackBar.open('Success..! Go Check your emails', '',{ duration: 4500, }).afterDismissed().subscribe(() => {});
        this.router.navigate(['/']);
      });
    }
  }
}
