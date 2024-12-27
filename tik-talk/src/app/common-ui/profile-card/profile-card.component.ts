import {Component, Input} from '@angular/core';
import {Profile} from "../../data/interfaces/profile.interface";
import {NgClass} from "@angular/common";

@Component({
  selector: 'app-profile-card',
  standalone: true,
  imports: [
    NgClass
  ],
  templateUrl: './profile-card.component.html',
  styleUrl: './profile-card.component.scss'
})
export class ProfileCardComponent {
  //@Input() profile?: Profile;
  @Input() profile?: Profile;
}
