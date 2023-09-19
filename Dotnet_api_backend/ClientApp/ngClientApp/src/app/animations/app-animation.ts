import {
    trigger,
    state,
    style,
    animate,
    transition,
  } from '@angular/animations';
  
  export const buttonAnimation = trigger('buttonState', [
    state('inactive', style({
      backgroundColor: '#E5E5E5',
      transform: 'scale(1)'
    })),
    state('active', style({
      backgroundColor: '#ccc',
      transform: 'scale(1.1)'
    })),
    transition('inactive => active', animate('100ms ease-in')),
    transition('active => inactive', animate('100ms ease-out'))
  ]);

  export const buttonFadeAnimation = trigger('buttonFadeState', [
    state('in', style({ opacity: 1 })),
    transition(':enter', [
      style({ opacity: 0 }),
      animate(300)
    ]),
    transition(':leave', [
      animate(300, style({ opacity: 0 }))
    ])
  ]);

  export const buttonSlideAnimation = trigger('buttonSlideState', [
    state('in', style({ transform: 'translateX(0)' })),
    transition(':enter', [
      style({ transform: 'translateX(-100%)' }),
      animate(300)
    ]),
    transition(':leave', [
      animate(300, style({ transform: 'translateX(100%)' }))
    ])
  ]);

  
  