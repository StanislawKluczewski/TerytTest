import { BreakpointObserver, Breakpoints } from "@angular/cdk/layout";
import { Injectable } from "@angular/core";
import { ScreenSizeType } from "./responsives.enum";

@Injectable({
  providedIn: "root"
})
export class ResponsiveWidthService {

  private screenSize = ScreenSizeType.Unknown;

  private readonly screenSizeBreakPoints = new Map([
    [Breakpoints.XSmall, ScreenSizeType.XSmall],
    [Breakpoints.Small, ScreenSizeType.Small],
    [Breakpoints.Medium, ScreenSizeType.Medium],
    [Breakpoints.Large, ScreenSizeType.Large],
    [Breakpoints.XLarge, ScreenSizeType.XLarge]
  ])

  constructor() { }

  public getScreenSize(): ScreenSizeType {
    return this.screenSize;
  }

  public checkScreenSize(breakpointObserver: BreakpointObserver): void {
    breakpointObserver.observe([
      Breakpoints.XSmall,
      Breakpoints.Small,
      Breakpoints.Medium,
      Breakpoints.Large,
      Breakpoints.XLarge
    ]).subscribe(result => {
      for (const query of Object.keys(result.breakpoints)) {
        if (result.breakpoints[query]) {
          this.screenSize = this.screenSizeBreakPoints.get(query) ?? ScreenSizeType.Unknown;
        }
      }
    })
  }

}
