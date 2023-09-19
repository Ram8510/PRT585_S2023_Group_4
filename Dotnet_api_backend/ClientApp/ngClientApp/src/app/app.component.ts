import { Component } from '@angular/core';
import { buttonFadeAnimation, buttonSlideAnimation } from './animations/app-animation';
import { getRandomColor } from './animations/random-color';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  animations: [
    buttonFadeAnimation,
    buttonSlideAnimation
  ]
})
export class AppComponent {
  title = 'ngClientApp';

  backgroundColor = '#ffffff'; // Default color
  textColor = '#000000';

  state: string = 'inactive';

  toggleState() {
    this.state = this.state === 'active' ? 'inactive' : 'active';
  }

  ngOnInit(){
    this.backgroundColor = getRandomColor(); 
    this.textColor = this.isLight(this.backgroundColor) ? '#000000' : '#ffffff';
  }

  // Determines if the color is "light" or "dark"
  isLight(color: any) {
    const hex = color.replace('#', '');
    const red = parseInt(hex.substr(0, 2), 16);
    const green = parseInt(hex.substr(2, 2), 16);
    const blue = parseInt(hex.substr(4, 2), 16);
    const luminance = (0.299 * red + 0.587 * green + 0.114 * blue) / 255;
    return luminance > 0.5;
  }
}
