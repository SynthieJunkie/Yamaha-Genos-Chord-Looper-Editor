# Yamaha-Genos-Chord-Looper-Editor

### Beschreibung:
Ein Programm zum einfachen Erstellen und Editieren von Chord-Looper Daten und Bänken für den Yamaha Genos. Getestet mit Firmware v2.13.

### Bild:
![Screenshot](Screenshot.png)

### Funktionen:
- Akkorde werden auf 1/4 Quantisiert.
- Transponierungs-Funktion.

### Bedienung:
- Bank: Im roten bereich können Bänke (CLB) verwaltet werden.
  - Bänke können erstellt, geladen und gespeichert werden.
  - Mit [Get <<] werden die Daten des selektierten Eintrags in das Akkord-Gitter geladen.
  - Mit [Set >>] werden die Daten des Akkord-Gitters in einen Bankeintrag geschrieben.
  - Mit [Delete] wird ein Bankeintrag gelöscht.

- File: Im gelben Bereich können Chord-Looper-Daten (CLD) verwaltet werden.
  - Chord-Looper-Daten können erstellt, geladen und gespeichert werden.
  - Akkorde können transponiert werden.

- Buffer: Im grünen Bereich werden bereits verwendete Akkorde zwischengespeichert.
  - Mit der linken Maustaste wird ein Akkord gewählt.
  - Mit der rechten Maustaste wird ein Akkord gelöscht.

- Chords: Im türkisen Bereich wird die Akkord-Sequenz festgelegt.
  - Mit der linken Maustaste wird ein Akkord geschrieben.
  - Mit der rechten Maustaste wird ein Akkord gelöscht.
  - Mit der mittleren Maustaste wird die Länge der Sequenz festgelegt.

- Mit [Escape] kann das Programm beendet werden.

### Änderungen
- v1.1
  - Puffer um 5 vergrößert.
  - Beim Laden werden alle Akkorde in den Puffer gespeichert.
  - Eine Auswahl zum Festlegen von Akkorden oder der Länge.
