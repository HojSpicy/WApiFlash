# Project Setup for GoalGlide

**Created by:** Hojjat Khabaregi  

## WApiFlash CleanArchitecture

1. **WApiFlash.Domain**: Have *Entities* (Model=>flash) & *UseCase* (Interface=>IGenericRepository).

2. **WApiFlash.Infrastructure** & **WApiFlash.Presentation(WebApi)**:Infrastructure Have (Data=>FlashDBContext) & (Repository=>GenericRepository) Presentation Have(Controller=>FlashController) both are for *InterfaceAdapter*