# Erweiterter Datei-Organisator

## Projektübersicht

Im Folgenden folgt eine Zusammenfassung von den ausführlichen Funktionen/Architektur: https://docs.google.com/document/d/1EgIPbSaFcXhHZJZmkh-ekFLRhzWi9LTVEHl8o-jiyPo/edit?usp=sharing

Der Erweiterte Datei-Organisator ist eine WPF-Anwendung, die entwickelt wurde, um eine umfassende und intuitive Lösung für die Dateiverwaltung zu bieten. Sie geht über traditionelle Datei-Explorer hinaus, indem sie leistungsstarke Funktionen wie Tagging, erweiterte Suche, Metadaten-Management, Batch-Operationen und eine Duplikatssuche integriert. [cite: 1] Das Projekt nutzt das MVVM (Model-View-ViewModel)-Entwurfsmuster für eine klare Trennung von Benutzeroberfläche und Logik, was zu einer besser wartbaren und skalierbaren Anwendung führt. [cite: 43, 44]

## Hauptfunktionen

### A. Kernfunktionen der Dateiverwaltung [cite: 34]
* **Intuitive Navigation:**
    * Adressleiste mit Pfadeingabe und Breadcrumb-Navigation. [cite: 1]
    * Vorwärts-, Rückwärts- und "Nach oben"-Schaltflächen. [cite: 2]
    * Favoriten/Lesezeichen für häufig besuchte Ordner. [cite: 2]
    * Optionale Unterstützung für mehrere Tabs für paralleles Browsen. [cite: 2]
* **Flexible Dateiansicht:**
    * Detailansicht mit anpassbaren Spalten (Name, Typ, Größe, Datum, Tags etc.) und Sortierung. [cite: 3]
    * Symbolansicht (klein, mittel, groß). [cite: 4]
    * Kachelansicht mit Miniaturvorschauen. [cite: 4]
    * Filterleiste für schnelles Filtern. [cite: 5]
* **Sichere Dateioperationen:**
    * Kopieren, Verschieben, Umbenennen, Löschen (mit Papierkorb-Option). [cite: 6]
    * Fortschrittsdialoge mit Abbruchmöglichkeit und Fehlerbehandlung. [cite: 6]
    * Konfliktbehandlung (Überschreiben, Umbenennen, Überspringen). [cite: 7]
    * Erstellen neuer Ordner und leerer Dateien. [cite: 7]
* **Kontextmenü:** Dynamische Menüs mit relevanten Aktionen für Dateien und Ordner. [cite: 8]

### B. Tagging-System [cite: 35]
* **Tag-Erstellung und -Verwaltung:** Hinzufügen, Umbenennen, Löschen von Tags mit optionaler Farbzuweisung. [cite: 9, 10] Zentrale Verwaltungsansicht für alle Tags. [cite: 10]
* **Tag-Zuweisung:** Einfaches Zuweisen und Entfernen von Tags zu/von Dateien und Ordnern (per Drag & Drop, Kontextmenü, dediziertem Panel). [cite: 11, 12] Autovervollständigung bei der Tag-Eingabe. [cite: 12]
* **Tag-basierte Navigation und Suche:** "Tag-Explorer"-Bereich und Filtern der aktuellen Ansicht nach Tags (UND/ODER-Logik). [cite: 13]
* **Speicherung:** Tags werden in einer SQLite-Datenbank gespeichert. [cite: 14]

### C. Erweiterte Suche & Filterung [cite: 36]
* **Globale Suchfunktion:** Suche über mehrere Laufwerke/Ordner. [cite: 15]
* **Kriterien:** Dateiname (mit Wildcards), Dateityp, Dateigröße, Erstellungs-/Änderungsdatum, Tags. [cite: 16]
* **Optionale Inhaltssuche** für Textdokumente. [cite: 17]
* **Speicherbare Suchanfragen.** [cite: 18]
* **Optionale Indizierung** für schnellere Suchen. [cite: 19]

### D. Metadaten-Management [cite: 37]
* **Anzeige:** Dediziertes Panel für Metadaten (EXIF, ID3, Dokumenteigenschaften). [cite: 20, 21]
* **Optionale Bearbeitung** gängiger Metadatenfelder. [cite: 22]
* **Extraktion** von Metadaten für Anzeige und Suche. [cite: 23]

### E. Batch-Operationen [cite: 37]
* **Massen-Umbenennung:** Mit Optionen für Textersetzung, Präfix/Suffix, Nummerierung, Datums-/Uhrzeiteinfügung, Metadaten-Platzhalter und Live-Vorschau. [cite: 24, 25]
* **Massen-Tagging.** [cite: 37]
* **Optionale Massen-Metadaten-Bearbeitung.** [cite: 26]

### F. Duplikatfinder [cite: 38]
* **Kriterien:** Dateiname, Dateigröße, Erstellungs-/Änderungsdatum, Byte-für-Byte-Vergleich, Datei-Hash (MD5, SHA256). [cite: 27]
* **Ergebnisansicht:** Gruppierte Anzeige von Duplikaten mit Optionen zum Löschen/Verschieben. [cite: 28, 29]

### G. Vorschaufenster [cite: 38]
* Integriertes Panel für die Vorschau von Bildern (JPG, PNG, GIF, BMP), Textdateien (TXT, MD, LOG etc.), PDFs. [cite: 30, 31]
* Optional Basisinformationen für andere Typen, Hex-Ansicht. [cite: 30]

### H. Anpassbarkeit und Benutzerfreundlichkeit [cite: 39]
* **Einstellungen-Dialog:** Konfiguration von Standardpfad, Tag-Farben, Datenbankpfad, Duplikatssuche-Kriterien. [cite: 31]
* **UI-Themes** (Hell/Dunkel). [cite: 32]
* **Tastaturkürzel.** [cite: 32]
* **Optionale Mehrsprachigkeit.** [cite: 33]

## Technisches Konzept (Fokus auf WPF)

* **Hauptsprache:** C# [cite: 43]
* **UI-Framework:** WPF (Windows Presentation Foundation) [cite: 43]
* **.NET-Version:** .NET 8 (oder aktuellste stabile Version) [cite: 43]
* **Kernkonzepte:**
    * **XAML:** Zur deklarativen Definition der Benutzeroberfläche. [cite: 43]
    * **MVVM (Model-View-ViewModel):** Primäres Entwurfsmuster. [cite: 44] ViewModels für jede View. [cite: 44]
    * **Datenbindung:** Intensiver Einsatz zur Verknüpfung von ViewModels mit Views. [cite: 45]
    * **Commands:** Verwendung von `ICommand` (z.B. RelayCommand aus CommunityToolkit.Mvvm). [cite: 46]
* **Datenbank für Tags/Metadaten-Index:** SQLite [cite: 47]
    * **Zugriff:** Entity Framework Core (EF Core) mit SQLite-Provider oder ein Micro-ORM wie Dapper. [cite: 47]
* **Wichtige Bibliotheken (Beispiele):**
    * `System.IO`: Für Dateioperationen. [cite: 48]
    * `CommunityToolkit.Mvvm`: Für MVVM-Basisfunktionalität. [cite: 48]
    * `Microsoft.EntityFrameworkCore.Sqlite`: Für EF Core mit SQLite. [cite: 49]
    * `TagLib-Sharp`: Zum Lesen/Schreiben von Metadaten. [cite: 49]
    * PDF-Viewer-Bibliothek (z.B. basierend auf WebView2, PdfiumViewer.WPF). [cite: 50]
    * `System.Security.Cryptography`: Für Datei-Hashes. [cite: 51]
    * Optional: Dependency Injection Framework (z.B. `Microsoft.Extensions.DependencyInjection`). [cite: 51]
    * Optional: Icon-Bibliotheken (z.B. `MahApps.Metro.IconPacks`). [cite: 51]

## Projektstruktur (MVVM-orientiert) [cite: 52]

ErweiterterDateiOrganisator/  (Root-Verzeichnis der Solution)
|
|-- ErweiterterDateiOrganisator.Core/  (Klassenbibliothek: Geschäftslogik, UI-unabhängig)
|   |
|   |-- Models/  (Datenmodelle der Anwendung)
|   |   |-- FileSystemEntry.cs         (Abstrakte Basisklasse für Dateien und Ordner)
|   |   |-- FileEntry.cs               (Repräsentiert eine Datei, erbt von FileSystemEntry)
|   |   |-- DirectoryEntry.cs          (Repräsentiert einen Ordner, erbt von FileSystemEntry)
|   |   |-- Tag.cs                     (Repräsentiert ein Tag)
|   |   |-- FileTagLink.cs             (Verknüpfungstabelle zwischen FileSystemEntry und Tag)
|   |   |-- SearchFilterCriteria.cs    (Kriterien für Suchvorgänge)
|   |   |-- AppConfiguration.cs        (Einstellungen der Anwendung)
|   |   |-- DuplicateFileGroup.cs      (Gruppe von als Duplikate identifizierten Dateien)
|   |   |-- MetadataItem.cs            (Repräsentiert ein einzelnes Metadatum Key-Value-Paar)
|   |
|   |-- Services/  (Interfaces und Implementierungen der Geschäftslogik)
|   |   |-- IFileSystemService.cs      (Interface für Datei- und Ordneroperationen)
|   |   |-- FileSystemService.cs       (Implementierung von IFileSystemService)
|   |   |-- ITagService.cs             (Interface für Tag-Management)
|   |   |-- TagService.cs              (Implementierung von ITagService)
|   |   |-- ISearchService.cs          (Interface für Suchfunktionen)
|   |   |-- SearchService.cs           (Implementierung von ISearchService)
|   |   |-- IMetadataService.cs        (Interface für das Lesen/Schreiben von Metadaten)
|   |   |-- MetadataService.cs         (Implementierung von IMetadataService)
|   |   |-- IDuplicateFinderService.cs (Interface für die Duplikatssuche)
|   |   |-- DuplicateFinderService.cs  (Implementierung von IDuplicateFinderService)
|   |   |-- IConfigurationService.cs   (Interface zum Laden/Speichern von Einstellungen)
|   |   |-- ConfigurationService.cs    (Implementierung von IConfigurationService)
|   |
|   |-- DataAccess/  (Datenzugriffsschicht)
|   |   |-- AppDbContext.cs            (EF Core DbContext für die SQLite-Datenbank)
|   |   |--DesignTimeDbContextFactory.cs (Für EF Core Migrationen zur Designzeit)
|   |   |-- IRepository.cs             (Optional: Generisches Repository-Interface)
|   |   |-- EfRepository.cs            (Optional: EF Core Implementierung von IRepository)
|   |
|   |-- Helpers/  (Hilfsklassen)
|   |   |-- HashGenerator.cs           (Zum Berechnen von Datei-Hashes)
|   |   |-- PathValidator.cs           (Zur Validierung von Pfaden)
|   |   |-- MetadataExtractor.cs       (Kapselt Logik zum Extrahieren von Metadaten, z.B. mit TagLib-Sharp)
|   |   |-- FileSystemWatcherWrapper.cs(Optional: Für die Überwachung von Dateiänderungen)
|
|-- ErweiterterDateiOrganisator.Wpf/  (WPF UI-Projekt)
|   |
|   |-- App.xaml                       (Globale Anwendungsdefinition, Ressourcen, Start-URI)
|   |-- App.xaml.cs                    (Code-Behind für App.xaml, Startup-Logik, DI-Container-Setup)
|   |
|   |-- Views/  (XAML-Dateien für Fenster und UserControls - die "V" in MVVM)
|   |   |-- MainView.xaml                (Hauptfenster der Anwendung)
|   |   |-- MainView.xaml.cs
|   |   |
|   |   |-- FileExplorerView.xaml        (UserControl für Dateibrowser-Teil: Adressleiste, Dateiliste)
|   |   |-- FileExplorerView.xaml.cs
|   |   |
|   |   |-- FileListItemView.xaml        (UserControl oder DataTemplate-Definition für ein einzelnes Element in der Dateiliste)
|   |   |-- FileListItemView.xaml.cs     (Kann leer sein, wenn als DataTemplate in einem ResourceDictionary)
|   |   |
|   |   |-- PreviewPaneView.xaml         (UserControl für die Dateivorschau)
|   |   |-- PreviewPaneView.xaml.cs
|   |   |
|   |   |-- TagEditorView.xaml           (UserControl zur Anzeige und Bearbeitung von Tags für ein Element)
|   |   |-- TagEditorView.xaml.cs
|   |   |
|   |   |-- TagManagementView.xaml       (UserControl oder Fenster zur Verwaltung aller Tags)
|   |   |-- TagManagementView.xaml.cs
|   |   |
|   |   |-- SettingsView.xaml            (UserControl oder Fenster für Anwendungseinstellungen)
|   |   |-- SettingsView.xaml.cs
|   |   |
|   |   |-- BatchRenameView.xaml         (UserControl oder Fenster für Massenumbenennung)
|   |   |-- BatchRenameView.xaml.cs
|   |   |
|   |   |-- DuplicateFinderView.xaml     (UserControl oder Fenster für Duplikatssuche)
|   |   |-- DuplicateFinderView.xaml.cs
|   |   |
|   |   |-- ProgressDialogView.xaml      (Fenster zur Anzeige von Fortschritt bei langl. Operationen)
|   |   |-- ProgressDialogView.xaml.cs
|   |
|   |-- ViewModels/  (C#-Klassen - die "VM" in MVVM)
|   |   |-- ViewModelBase.cs             (Basisklasse, implementiert INotifyPropertyChanged, ggf. von CommunityToolkit.Mvvm.ObservableObject)
|   |   |-- MainViewModel.cs             (ViewModel für MainView)
|   |   |-- FileExplorerViewModel.cs     (ViewModel für FileExplorerView)
|   |   |-- FileListItemViewModel.cs     (ViewModel für ein einzelnes Element in der Dateiliste)
|   |   |-- PreviewPaneViewModel.cs      (ViewModel für PreviewPaneView)
|   |   |-- TagEditorViewModel.cs        (ViewModel für TagEditorView)
|   |   |-- TagManagementViewModel.cs    (ViewModel für TagManagementView)
|   |   |-- SettingsViewModel.cs         (ViewModel für SettingsView)
|   |   |-- BatchRenameViewModel.cs      (ViewModel für BatchRenameView)
|   |   |-- DuplicateFinderViewModel.cs  (ViewModel für DuplicateFinderView)
|   |   |-- ProgressDialogViewModel.cs   (ViewModel für ProgressDialogView)
|   |   |-- TagViewModel.cs              (Repräsentiert ein einzelnes Tag im UI-Kontext, z.B. mit Selektionsstatus)
|   |
|   |-- Controls/  (Benutzerdefinierte, wiederverwendbare WPF-Steuerelemente, falls komplexer als UserControls)
|   |   |-- PathBreadcrumbBar.xaml       (Beispiel: Control für Breadcrumb-Navigation)
|   |   |-- PathBreadcrumbBar.xaml.cs
|   |   |-- (Weitere Custom Controls bei Bedarf)
|   |
|   |-- Converters/  (IValueConverter Implementierungen für Datenbindungen)
|   |   |-- BooleanToVisibilityConverter.cs
|   |   |-- FilePathToIconConverter.cs     (Wandelt Dateipfad/Typ in ein Icon um)
|   |   |-- TagColorToBrushConverter.cs    (Wandelt Hex-Farbcode eines Tags in einen WPF Brush um)
|   |   |-- FileSizeToStringConverter.cs   (Formatiert Dateigröße lesbar, z.B. in KB, MB)
|   |   |-- DateTimeToStringConverter.cs   (Formatiert Datum/Zeit)
|   |   |-- InverseBooleanConverter.cs
|   |
|   |-- Resources/  (Resource Dictionaries für Stile, Vorlagen etc.)
|   |   |-- Styles.xaml                  (Globale Stile für Standard-Controls, Fensterstile)
|   |   |-- DataTemplates.xaml           (DataTemplates für die Darstellung von Modellen/ViewModels in Listen etc.)
|   |   |-- Brushes.xaml                 (Zentral definierte Farb-Brushes)
|   |   |-- Icons.xaml                   (Vektorbasierte Icons als XAML-Ressourcen, z.B. Path-Daten)
|   |   |-- ConvertersResourceDictionary.xaml (Optional: Zentrales Dictionary zum Referenzieren der Converters)
|   |
|   |-- Services/  (UI-spezifische Dienste, die von ViewModels genutzt werden)
|   |   |-- IDialogService.cs            (Interface zum Anzeigen von Standard-Dialogen oder benutzerdefinierten Dialog-Views)
|   |   |-- DialogService.cs             (Implementierung von IDialogService)
|   |   |-- INavigationService.cs        (Optional: Für Navigation zwischen verschiedenen Haupt-Views in einem Single-Window-Setup)
|   |   |-- NavigationService.cs         (Optional: Implementierung von INavigationService)
|   |   |-- IClipboardService.cs         (Optional: Interface für Interaktionen mit der Zwischenablage)
|   |   |-- ClipboardService.cs          (Optional: Implementierung)
|   |
|   |-- Behaviors/ (Optional: Für angehängte Verhaltensweisen in XAML, um Code-Behind zu reduzieren)
|   |   |-- EventToCommandBehavior.cs    (Beispiel: Leitet ein Event an ein Command im ViewModel weiter)
|   |
|   |-- Assets/ (Bilder, Schriftarten etc.)
|   |   |-- Fonts/
|   |   |-- Images/
|   |       |-- default_file_icon.png
|   |       |-- folder_icon.png
|
|-- ErweiterterDateiOrganisator.Tests/  (Unit-Test-Projekt)
|   |
|   |-- Core.Tests/  (Tests für die Logik im Core-Projekt)
|   |   |-- FileSystemServiceTests.cs
|   |   |-- TagServiceTests.cs
|   |   |-- SearchServiceTests.cs
|   |   |-- (Weitere Tests für andere Core-Services)
|   |
|   |-- Wpf.Tests/  (Tests für die ViewModels des WPF-Projekts)
|   |   |-- MainViewModelTests.cs
|   |   |-- FileExplorerViewModelTests.cs
|   |   |-- (Weitere Tests für andere ViewModels)
|
|-- .gitignore                       (Git-Ignore-Datei)
|-- README.md                        (Projektbeschreibung)
|-- ErweiterterDateiOrganisator.sln  (Solution-Datei)

## Zusammenspiel der Klassen (MVVM)

* **App.xaml.cs:** Startet die Anwendung, konfiguriert Dependency Injection (DI), erstellt das `MainViewModel` und setzt es als `DataContext` für die `MainView`. [cite: 88, 89, 90]
* **Views (XAML):** Definieren die visuelle Struktur. Binden Steuerelemente an Eigenschaften und Commands des zugehörigen ViewModels. [cite: 91, 93] Nutzen `DataTemplates`. [cite: 94]
* **ViewModels (C#):** Enthalten die Präsentationslogik, implementieren `INotifyPropertyChanged`. [cite: 95, 97] Stellen öffentliche Eigenschaften und `ICommand`-Eigenschaften bereit. [cite: 98] Rufen Services aus dem `.Core`-Projekt auf und nutzen UI-spezifische Services. [cite: 99, 100]
* **Services (.Core):** UI-unabhängige Geschäftslogik und Datenzugriff. [cite: 101] Werden per DI in ViewModels injiziert. [cite: 101]
* **Models (.Core):** Reine Datencontainer. [cite: 102]
* **Converters:** Wandeln Daten für die Anzeige um (z.B. `BooleanToVisibilityConverter`). [cite: 104]
* **ResourceDictionaries:** Definieren Aussehen und Verhalten (Styles, DataTemplates). [cite: 105, 106, 107]
