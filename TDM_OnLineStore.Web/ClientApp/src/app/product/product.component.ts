import { Component } from "@angular/core"

@Component({
  selector: "app-product",
  template: "<html><body>{{ getName() }}</body></html>"
})


export class ProductComponent {
  public name: string;
  public isReadyToSale: boolean;

  public getName(): string {
    //return this.name;
    return "Sansung";
  }
}
