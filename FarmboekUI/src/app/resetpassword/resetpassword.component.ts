import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MatSnackBar } from '@angular/material';
import { SharedService } from 'app/shared/shared.service';
import { resetPasswordDto } from 'app/shared/shared.models';

@Component({
  selector: 'app-resetpassword',
  templateUrl: './resetpassword.component.html',
  styleUrls: ['./resetpassword.component.scss']
})
export class ResetpasswordComponent implements OnInit {

  username: string;
  token: string;
  Npassword = '';
  Cpassword = '';
  myData: resetPasswordDto;
  constructor(private route: ActivatedRoute, public snackBar: MatSnackBar, private service: SharedService, private router: Router) { }

  ngOnInit() {
    this.route.params.subscribe(a => {
      this.username = a.username;
      this.token = a.token;
    });
    // console.log(this.username + ' ' + this.token);
  }

  submit() {
    if (this.Npassword == this.Cpassword) {
      this.myData = {username: this.username, token: this.token, password: this.Npassword}
      this.service.resetPassword(this.myData).subscribe(a => {
        this.snackBar.open('Password has been reset', '',{ duration: 4500, }).afterDismissed().subscribe(() => {});
        this.router.navigate(['/']);
      });
    }else {
      this.snackBar.open('Passwords does not match', '',{ duration: 4500, }).afterDismissed().subscribe(() => {});
    }
    // console.log('Sending reset password request');
  }
}
