Im Folgenden folgt eine Zusammenfassung von den ausführlichen Funktionen/Architektur: https://docs.google.com/document/d/1EgIPbSaFcXhHZJZmkh-ekFLRhzWi9LTVEHl8o-jiyPo/edit?usp=sharing

# 🚀 Erweiterter Datei-Organisator 📂

## 🌟 Projektübersicht

Willkommen beim Erweiterten Datei-Organisator! Diese WPF-Anwendung ist dein neuer bester Freund, wenn es um Dateiverwaltung geht. 🤓 Sie ist mehr als nur ein langweiliger Datei-Explorer – sie steckt voller Power-Features wie Tagging, einer Super-Suche, Metadaten-Management, Batch-Operationen und einem cleveren Duplikatfinder. Das Ganze basiert auf dem MVVM (Model-View-ViewModel)-Muster, was bedeutet: sauberer Code, einfache Wartung und eine App, die mit deinen Bedürfnissen wächst. 🏗️

## 🔥 Hauptfunktionen

### A. 🧭 Kernfunktionen der Dateiverwaltung
* **Intuitive Navigation:**
    * Adressleiste mit Pfadeingabe & Breadcrumbs. 🗺️
    * Vorwärts-, Rückwärts- & "Nach oben"-Buttons. ⬆️⬇️⬅️➡️
    * Favoriten/Lesezeichen für deine Lieblingsordner. ⭐
    * Optionale Tabs für Multitasking-Ninjas. 탭
* **Flexible Dateiansicht:**
    * Detailansicht: Spalten anpassen (Name, Typ, Größe, Datum, Tags etc.) & easy sortieren. 📊
    * Symbolansicht: Klein, mittel, groß – du entscheidest! 🖼️
    * Kachelansicht: Mit schicken Miniaturvorschauen. 🏞️
    * Filterleiste: Finde blitzschnell, was du suchst. 🔍
* **Sichere Dateioperationen:**
    * Kopieren, Verschieben, Umbenennen, Löschen (mit Papierkorb-Rettungsnetz 🗑️).
    * Dialoge mit Fortschrittsanzeige, Abbruchmöglichkeit & Fehlerbehandlung. 🚦
    * Konfliktlösung (Datei schon da? Überschreiben, Umbenennen, Überspringen). 🤝
    * Neue Ordner & leere Dateien erstellen. ➕
* **Kontextmenü:** Dynamische Menüs, die immer die richtigen Aktionen parat haben. 🖱️✨

### B. 🏷️ Tagging-System
* **Tag-Erstellung & -Verwaltung:** Neue Tags mit Namen & Farbe erstellen, umbenennen, löschen. 🎨 Plus eine zentrale Übersicht.
* **Tag-Zuweisung:** Tags easy per Drag & Drop, Kontextmenü oder Panel zuweisen & entfernen. Autovervollständigung inklusive! ✍️
* **Tag-basierte Navigation & Suche:** Ein "Tag-Explorer" zeigt dir alle Dateien/Ordner zu einem Tag. Filter die aktuelle Ansicht nach einzelnen oder mehreren Tags (UND/ODER). 🧭
* **Speicherung:** Tags landen sicher in einer SQLite-Datenbank. 💾

### C. 🔬 Erweiterte Suche & Filterung
* **Globale Suchfunktion:** Durchsucht mehrere Laufwerke/Ordner auf einmal. 🌍
* **Suchkriterien:** Dateiname (mit Wildcards `*`, `?`), Typ (.jpg, .docx), Größe, Datum, Tags.
* **Optionale Inhaltssuche** für Textdokumente. 📜
* **Suchanfragen speichern** und später wiederverwenden. 📌
* **Optionale Indizierung** für Suchen in Lichtgeschwindigkeit. ⚡

### D. Metadata-Management
* **Anzeige:** Eigenes Panel für Metadaten (EXIF für Bilder, ID3 für Audio, Dokumentinfos etc.). ℹ️
* **Optionale Bearbeitung** gängiger Metadatenfelder. ✏️
* **Extraktion** von Metadaten für Anzeige & Suche. 🔮

### E. 🪄 Batch-Operationen
* **Massen-Umbenennung:** Ein mächtiges Tool mit Textersetzung, Präfix/Suffix, Nummerierung, Datum/Uhrzeit, Metadaten-Platzhaltern & Live-Vorschau. 🔄
* **Massen-Tagging.** 🏷️🏷️🏷️
* **Optionale Massen-Metadaten-Bearbeitung.** 🎶

### F. 👯 Duplikatfinder
* **Kriterien:** Dateiname, Größe, Datum, Byte-für-Byte-Vergleich (supergenau!), Datei-Hash (MD5, SHA256 – der goldene Mittelweg). ⚖️
* **Ergebnisansicht:** Duplikate werden gruppiert angezeigt, mit Optionen zum Aufräumen. 🧹

### G. 🖼️ Vorschaufenster
* Integriertes Panel für die Vorschau von Bildern (JPG, PNG, GIF, BMP), Textdateien (TXT, MD, LOG etc.), PDFs. 📄
* Optional: Basisinfos für andere Typen, Hex-Ansicht für Nerds. 🤓

### H. 🛠️ Anpassbarkeit & Benutzerfreundlichkeit
* **Einstellungen-Dialog:** Standardpfad, Tag-Farben, Datenbankpfad, Duplikatssuche-Kriterien anpassen. ⚙️
* **UI-Themes** (Hell/Dunkel – Dark Mode rockt!). 🌓
* **Tastaturkürzel** für schnelle Aktionen. ⌨️
* **Optionale Mehrsprachigkeit.** 🌐

## 💡 Technisches Konzept (Fokus auf WPF)

* **Hauptsprache:** C# 💻
* **UI-Framework:** WPF (Windows Presentation Foundation) ✨
* **.NET-Version:** .NET 8 (oder die aktuellste stabile Version) 🚀
* **Kernkonzepte:**
    * **XAML:** Für die schicke, deklarative UI-Definition. 🎨
    * **MVVM (Model-View-ViewModel):** Unser Architekturchampion für sauberen Code. 🧱
    * **Datenbindung:** Verknüpft ViewModels und Views magisch. 🔗
    * **Commands:** `ICommand` (z.B. RelayCommand aus CommunityToolkit.Mvvm) für Aktionen. ⚡
* **Datenbank für Tags/Metadaten-Index:** SQLite 💾
    * **Zugriff:** Entity Framework Core (EF Core) mit SQLite-Provider oder ein flinkes Micro-ORM wie Dapper.
* **Wichtige Bibliotheken (Beispiele):**
    * `System.IO`: Für Datei-Action. 📂
    * `CommunityToolkit.Mvvm`: MVVM-Superkräfte! 💪
    * `Microsoft.EntityFrameworkCore.Sqlite`: EF Core + SQLite = ❤️.
    * `TagLib-Sharp`: Metadaten lesen & schreiben. 🏷️✏️
    * PDF-Viewer-Bibliothek (z.B. basierend auf WebView2, PdfiumViewer.WPF). 📄
    * `System.Security.Cryptography`: Für sichere Datei-Hashes. 🔑
    * Optional: Dependency Injection Framework (z.B. `Microsoft.Extensions.DependencyInjection`). 💉
    * Optional: Icon-Bibliotheken (z.B. `MahApps.Metro.IconPacks`) für noch mehr Style. 😎

## 🏗️ Projektstruktur (MVVM-Style)

ErweiterterDateiOrganisator/

|-- 📦 ErweiterterDateiOrganisator.Core/         (Hier wohnt die Logik & die Datenmodelle)
|   |-- 🧩 Models/                               (FileEntry.cs, Tag.cs, etc.) 
|   |-- ⚙️ Services/                             (IFileSystemService.cs, etc.) 
|   |-- 🗃️ DataAccess/                           (AppDbContext.cs, etc.) 
|   |-- 🛠️ Helpers/                               (HashGenerator.cs, etc.) 
|

|-- 🖥️ ErweiterterDateiOrganisator.Wpf/          (Das WPF UI-Projekt – hier wird's bunt!)

|   |-- 🚀 App.xaml / App.xaml.cs                (Startrampe der App, DI-Setup)

|   |-- 🖼️ Views/                                (XAML-Dateien für Fenster & UserControls)

|   |   |-- 🏠 MainView.xaml                     (Das Hauptquartier)

|   |   |-- ⚙️ SettingsView.xaml                 (Der Einstellungs-Hub)

|   |   |-- 📂 FileExplorerView.xaml             (Die Kommandozentrale für Dateien)

|   |   |-- 👁️ PreviewPaneView.xaml              (Das Vorschaufenster)

|   |   |-- 🏷️ TagEditorView.xaml                (Der Tag-Manager)

|   |   |-- 📄 FileListItemView.xaml             (Ein einzelner Dateieintrag)

|   |   |-- ... (weitere coole Views)

|   |

|   |-- 🧠 ViewModels/                           (Die C#-Gehirne der Präsentation)

|   |   |-- 🧬 ViewModelBase.cs                  (Die DNA aller ViewModels mit INotifyPropertyChanged)

|   |   |-- 👑 MainViewModel.cs

|   |   |-- 🧭 FileExplorerViewModel.cs

|   |   |-- ✨ FileListItemViewModel.cs          (ViewModel für jeden Dateieintrag)

|   |   |-- 🖼️ PreviewPaneViewModel.cs

|   |   |-- 🏷️ TagEditorViewModel.cs

|   |   |-- ... (weitere schlaue ViewModels)

|   |

|   |-- 🎨 Controls/                             (Optionale Custom WPF Controls)

|   |   |-- 🗺️ PathBreadcrumbBar.cs

|   |

|   |-- 🔄 Converters/                           (IValueConverter – die kleinen Helferlein)

|   |   |-- 🌈 TagColorToBrushConverter.cs

|   |   |-- ...

|   |

|   |-- 📚 Resources/                            (Resource Dictionaries – Schatztruhen für Styles)

|   |   |-- 🖌️ Styles.xaml                       (Globale & spezifische Control-Styles)

|   |   |-- 📝 DataTemplates.xaml                (Wie deine Daten aussehen sollen)

|   |   |-- ...

|   |

|   |-- 🛎️ Services/ (UI-spezifische Dienste)

|   |   |-- 💬 IDialogService.cs / DialogService.cs (Für Dialoge vom ViewModel aus)

|   |   |-- ...

|

|-- ✅ ErweiterterDateiOrganisator.Tests/        (Unit-Test-Projekt – damit alles rund läuft!)

|   |-- 🧪 Core.Tests/                           (Tests für die Core-Services)

|   |-- 🧪 Wpf.Tests/                             (Tests für die ViewModels)

|

|-- 📜 Solution-Datei (.sln)

## 🤝 Zusammenspiel der Klassen (MVVM-Magie)

* **App.xaml.cs:** 🚀 Startet die Anwendung, mixt den Dependency Injection (DI) Cocktail, schnappt sich das `MainViewModel` und verheiratet es mit der `MainView`.
* **Views (XAML):** 🎨 Definieren, wie's aussieht. Binden Controls an Eigenschaften & Commands des zugehörigen ViewModels. Nutzen `DataTemplates` für schicke Listen.
* **ViewModels (C#):** 🧠 Die Strippenzieher! Enthalten die Logik, implementieren `INotifyPropertyChanged`. Stellen öffentliche Eigenschaften & `ICommand`s bereit. Rufen Services aus dem `.Core`-Projekt auf und nutzen UI-spezifische Services.
* **Services (.Core):** ⚙️ UI-unabhängige Business-Logik und Datenzugriff. Werden per DI in die ViewModels gezaubert.
* **Models (.Core):** 🧱 Reine Datenbausteine.
* **Converters:** ↔️ Kleine Übersetzer für die Anzeige (z.B. `BooleanToVisibilityConverter`).
* **ResourceDictionaries:** 🖌️ Bestimmen Look & Feel (Styles, DataTemplates).
