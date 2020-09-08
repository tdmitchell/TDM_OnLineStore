import { Component } from "@angular/core"
import { User } from "../../model/user";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})


export class LoginComponent {
  public user;
  public authentifiedUser: boolean;

  constructor() {
    this.user = new User();
  }

  //Adding a Image
  public imageAddress = "https://thumbs.dreamstime.com/t/buy-now-icon-web-button-buy-now-icon-web-button-vector-illustration-isolated-white-background-shadow-119950672.jpg";
  public title = "Buy Now Image";

  enter(): void {
    if (this.user.email == "a" && this.user.password == "1") {
      this.authentifiedUser = true;
    }
  }


}
