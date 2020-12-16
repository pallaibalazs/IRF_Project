# IRF_Project
NETFLiX PRO app

Készítette: Pallai Balázs István (AY868K)

A projektem lényege, hogy kilistázza a felhasználó számára a legnézettebb Netflix sorozatokat, a hozzájuk tartrozó adatokkal. Ezek az adatok rendre a bemutató éve, a korhatár besoroáls, az IMDB értékelés, illetve logikai változóként, hogy megtekinthető-e jelenleg a Netflixen (0 nem, 1 igen). Az adatokat XML-ből töltöttem be, majd szűrhetővé tettem a felsorolt adatok alapján. A felhasználó exportálhatja a megkapott listát .CSV formátumban. 

Másik funkciója az IMDB értékelések kimutatása oszlopdiagram segítségével, melyekhez az adatot szintén az előző XML fájlból nyertem ki. Ezek tízes skálán mutatják be mennyire voltak népszerűek az adott sorozatok.

Végül de nem utolsó sorban a program kilistázza az elmúlt 10 nap (2020.12.16. dátumhoz viszonyítva) a NFLX részvények nyitó értékének alakulását. Ezeket az adatokat megkapjuk egy dataGridview-ban,. illetve egy vonaldiagramra kirajzolva, ezzel is áttekinthetőbbé téve az árfolyam alakulását.

A program lehetőségként kínálja fel, hogy 5 perc inaktivitás után megkíséreljen egy kilépést, viszont a kilépés előtt feltesz egy biztonsági kérdést, hogy mindenképp kilépnénk-e.
