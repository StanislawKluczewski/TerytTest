import { NgModule } from "@angular/core";
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from "@angular/material/icon";
import { MatListModule } from "@angular/material/list";
import { MatButtonModule } from "@angular/material/button";
import { MenuComponent } from "./components/menu/menu.component";


@NgModule(
  {
    declarations: [
      MenuComponent
    ],
    imports: [
      MatSidenavModule,
      MatToolbarModule,
      MatIconModule,
      MatListModule,
      MatButtonModule
    ],
    exports: [
      MenuComponent
    ]
  }
)
export class CoreModule { }

