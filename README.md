# Kuriimu2
Kuriimu2 is a general purpose game translation project manager and toolkit for authors of fan translations and game mods.

## Requirements
You need to have the .Net Core Desktop Runtime 3.1.6 installed on your system.<br>
If you are on Mac or Linux, you can just install the .Net Core Runtime 3.1.6.<br>
We build against the .Net Core SDK version 3.1.302.<br>
You can get it here: https://dotnet.microsoft.com/download/dotnet-core/3.1

## Download
You can download the newest build of Kuriimu2 in the "Actions" tab. Just select the newest successful build and download its artifact.<br>
You need to be logged in at github to download artifacts from a successful build.<br>
Those builds are considered beta and can contain bugs and unfinished features.

There are several different GUI's you can choose from:
1. WinForms: A graphical user interface in a more classic design. Can only be executed on Windows.
2. EtoForms: A graphical user interface in a look native to the operating system. There are artifacts for Mac, Linux, and Windows.
3. CommandLine: A command line interface of the main features of Kuriimu2. Can be executed on Mac, Linux, and Windows.

## Usage
Kuriimu2 consists of many libraries and user interfaces. A build from "Actions" contains a ready-to-run GUI for you to execute.

## Status
![Kuriimu2 EtoForms](https://github.com/FanTranslatorsInternational/Kuriimu2/workflows/Kuriimu2%20EtoForms/badge.svg?branch=master&event=push)

### Architecture
1. Kontract - The main API host for all interfaces and base classes. Defines interfaces like ITextAdapter, IFontAdapter, ILoadFiles, etc...
1. Komponent - A series of tools used by plugins, Kore and sometimes the UI, contains BinaryReader/WriterX and a bunch of other utility classes and helpers.
1. Kanvas - The image library. Handles all things images, ETC1/A4, DXT, PVRTC, ATC, IndexedColor, etc...
1. Kryptography - Contains all compression, encryption, and hashing classes.
1. Kore - The main API that the UI and eventual CLI uses to load plugins and do all Plugin-bound functions. Batch import/export and other functions.
1. Kuriimu2 - The WPF UI that is the main user-side program.

### Plugins
* Plugins currently make use of a dev-side nuget package that contains all five of the main libraries.
  * The libraries will be separated later on down the road.
