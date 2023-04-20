import { BreakpointObserver, Breakpoints } from "@angular/cdk/layout";
import { Injectable } from "@angular/core";
import { BreakpointType, DeviceType, OrientationType } from "./responsives.enum";

@Injectable({
  providedIn: "root"
})
export class ResponsiveOrientationTypeDeviceService {

  private deviceType = DeviceType.Unknown;
  private orientation = OrientationType.Unknown;

  private readonly deviceAndOrientation = new Map([
    [Breakpoints.HandsetLandscape, BreakpointType.TabletLandscape],
    [Breakpoints.HandsetPortrait, BreakpointType.HandsetPortrait],
    [Breakpoints.TabletLandscape, BreakpointType.TabletLandscape],
    [Breakpoints.TabletPortrait, BreakpointType.TabletPortrait],
    [Breakpoints.WebLandscape, BreakpointType.WebLandscape],
    [Breakpoints.WebPortrait, BreakpointType.WebPortrait]
  ])

  constructor() { }


  public getDeviceType(): DeviceType {
    return this.deviceType;
  }

  public getOrientation(): OrientationType {
    return this.orientation;
  }

  public isOrientationPortrait(): boolean {
    return this.orientation == OrientationType.Portrait;
  }

  public isOrientationLandscape(): boolean {
    return this.orientation == OrientationType.Landscape;
  }

  public isDeviceDesktop(): boolean {
    return this.deviceType == DeviceType.Web;
  }

  public isDeviceTablet(): boolean {
    return this.deviceType == DeviceType.Tablet;
  }

  public isDeviceMobile(): boolean {
    return this.deviceType == DeviceType.Handset;
  }

  public checkDeviceTypeAndOrientation(breakpointObserver: BreakpointObserver): void {
    breakpointObserver.observe([
      Breakpoints.HandsetLandscape, Breakpoints.HandsetPortrait,
      Breakpoints.TabletLandscape, Breakpoints.TabletPortrait,
      Breakpoints.WebLandscape, Breakpoints.WebLandscape
    ]).subscribe(result => {
      let orientationTypes = Object.keys(OrientationType).map(key => key);
      let deviceTypes = Object.keys(DeviceType).map(key => key);
      for (const query of Object.keys(result.breakpoints)) {
        if (result.breakpoints[query]) {
          let type = this.deviceAndOrientation.get(query) ?? BreakpointType.Unknown;

          orientationTypes.forEach(element => {
            if (type.indexOf(element) !== -1) {
              this.orientation = element as OrientationType;
            }
          });

          deviceTypes.forEach(element => {
            if (type.indexOf(element) !== -1) {
              this.deviceType = element as DeviceType;
            }
          })
        }
      }
    })
  }

}
