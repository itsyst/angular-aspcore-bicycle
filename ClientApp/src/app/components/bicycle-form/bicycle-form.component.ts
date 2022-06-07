import { MakeService } from '@/app/services/make/make.service';
import { Make } from '@/app/types/make';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-bicycle-form',
  templateUrl: './bicycle-form.component.html',
  styleUrls: ['./bicycle-form.component.css']
})
export class BicycleFormComponent implements OnInit {
  makes: Make[] = [];
  constructor (private makeService: MakeService) { }

  getMakes(): void {
    this.makeService
      .getAll()
      .subscribe((makes: Make[]) => {
        this.makes = Object.values(Object.values(makes));
        console.log("makes", this.makes);
      });
  }

  ngOnInit(): void {
    this.getMakes();
  }
}
