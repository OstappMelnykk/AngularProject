import {Component, inject} from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {ProfileCardComponent} from "./common-ui/profile-card/profile-card.component";
import {ProfileService} from "./data/services/profile.service";
import {JsonPipe} from "@angular/common";
import {Profile} from "./data/interfaces/profile.interface";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ProfileCardComponent, JsonPipe],

  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  profileService = inject(ProfileService)
  profiles : Profile[] = []

  /*constructor() {
    this.profileService.getTestAccounts()
      .subscribe(val => {
        this.profiles = val
    })
  }*/

  constructor() {
    this.profileService.getTestAccounts()
      .subscribe({
        next: (val) => {
          this.profiles = val;
        },
        error: (err) => {
          console.error('Error fetching profiles:', err);
        }
      });
  }

}
