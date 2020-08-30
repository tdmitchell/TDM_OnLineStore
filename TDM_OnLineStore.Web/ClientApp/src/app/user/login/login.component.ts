import { Component } from "@angular/core"

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})


export class LoginComponent {
  public email = "";
  public password = "";

  public imageAddress = "https://thumbs.dreamstime.com/t/buy-now-icon-web-button-buy-now-icon-web-button-vector-illustration-isolated-white-background-shadow-119950672.jpg";
  public title = "Buy Now Image";

  enter(): void {
    alert(this.email);
  }


}
