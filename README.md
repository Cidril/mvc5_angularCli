# mvc5_angularCli
Ein leeres Testprojekt mit Visual Studio 2015 Community erstellt.
Voraussetzungen:
node.js (npm)

1. clonen
2. cd mvc5_angularCli/Pv-Inf/angular
3. npm install
4. npm install -g angular-cli

ACHTUNG die "ng" befehle müssen im /angular ordner ausgeführt werden

#################################
Build:
das typescript (angular) wird nicht automatisch mit visual studio gebuildet.
Sondern mit command "ng build" wird das ganze typescript in den /dist/ ordner gebuildet.

#################################
Usage:
angular auf seperatem Server starten mit "ng serve"
dass hostet die angular seite auf localhost:4200 und achtet auf änderungen in den typescript und buildet automatisch on save

Also angular development am anfang einmal "ng serve" ausführen und dann arbeiten

beim Arbeiten am MVC wie gehabt mit visual studio builden und ausführen

##################################
einziges Problem: 
es wird nicht die selbe index.html verwendet
das heißt wenn im _layout.cshtml was geändert wird, muss das auch im /angular/src/index.html geändert werden und umgekehrt