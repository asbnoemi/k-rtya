# k-rtya
beadando
UML osztály- és objektum diagramok segítségével tervezzen meg és C# nyelven valósítson meg egy
olyan alkalmazást, amely képes előállítani egy kártyaalpú mágikus négyzetet. A magyar kártyában
négy szín (piros, zöld, makk, tök) fordul elő, mindegyik színből van számozott (7...10) és figurás
(alsó, felső, király, ász) lap, így összesen 32 lapos. Figurás lapokból 4 különböző van, ha mind a 4
szín figurás lapjait összeszedjük, akkor pontosan 16 lapot kapunk. Alkalmazzunk kódolást a
kártyákra. Jelöljük 11, 12, 13, 14-gyel a piros színű alsó, felső, király, ász lapokat! Hasonlóan 21, 22,
23, 24 értékekkel a zöld alsó, felső, király, ász, 31, 32, 33, 34-gyel a makk, 41, 42, 43, 44 értékkel a
tök színű lapokat. A szabályt ekkor úgy fogalmazhatjuk meg: egyetlen sorban, oszlopban, átlóban
sem fordulhat elő két olyan számérték, melyeknek 10-zel való egész vagy maradékos osztásának
eredménye egyenlő. Ha a 10-zel való egész osztás eredménye egyenlő lenne, akkor az egyforma színt
jelentene. Ha a modulo 10 értéke egyenlő, akkor az egyforma figurát jelentene. Készítsük el a mátrix
egy alapkitöltését, helyezzük el benne az összes számértéket módszeresen sorfolytonosan! Az így
feltöltött mátrix nyilván nem felel meg a feltételeknek. Válasszunk ki két cellát véletlenszerűen, és
cseréljük fel a bennük lévő értékeket, mindaddig, míg meg nem kapjuk a kért tulajdonságú
végeredményt! Sajnos gyakorlatilag reménytelen, hogy a véletlen cserék révén helyes mátrixot
kapjunk. Ezért meg kell keresnünk, melyik sorok vagy mely oszlopok hiúsítják meg a kívánt
végeredmény elérését, azon belül melyik két cella okozza a konfliktust. Elegendőek az egyik
problémás cella koordinátái. Válasszunk hozzá véletlenszerűen egy másik cellát a mátrixból, és
cseréljük fel e két cella tartalmát!
