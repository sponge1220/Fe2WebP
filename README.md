# Image Format Converter for FE Projects

This C# program automates the conversion of `.png` and `.jpg` images to `.webp` format within a specified directory, ideally suited for Next.js projects. It also updates all references to these images in HTML, JS, JSX, and TSX files to point to the new `.webp` files, ensuring your project utilizes modern image formats for improved performance and reduced file sizes.

## Features

- Recursively converts all `.png` and `.jpg` images to `.webp` format.
- Updates references from `.png` and `.jpg` to `.webp` in all HTML, JS, JSX, and TSX files.
- Deletes the original `.png` and `.jpg` files after conversion to optimize storage.
- Easy to use with a single directory input.

## Requirements

- .NET Core 8 or higher
- Magick.NET-Q8-AnyCPU NuGet package

## Installation

1. Ensure .NET Core 8 or higher is installed on your system.
2. Clone this repository or download the source files.
3. Navigate to the project directory and install the Magick.NET-Q8-AnyCPU package via NuGet:
   ```
   Install-Package Magick.NET-Q8-AnyCPU
   ```

## Usage

To use this program, follow the steps below:

1. Open a command line interface (CLI).
2. Navigate to the directory containing the compiled C# program.
3. Run the program without any arguments. The program will prompt you for the source directory:
   ```
   dotnet ImageFormatConverter.dll
   ```
4. When prompted with `sourceDir:`, enter the full path to your Next.js project directory where your images are located and press Enter.

Example:
```
sourceDir:
C:\path\to\your\project\directory
```

The program will then start converting `.png` and `.jpg` images to `.webp` format within the specified directory and update all references in HTML, JS, JSX, and TSX files accordingly. Original `.png` and `.jpg` files will be deleted after conversion to optimize storage.

## How It Works

The program performs the following operations:
- Scans the specified directory for `.png` and `.jpg` files.
- Converts these images to `.webp` format using the Magick.NET library.
- Searches for `.html`, `.js`, `.jsx`, and `.tsx` files in the directory and its subdirectories.
- Replaces all occurrences of `.png` and `.jpg` in these files with `.webp`.
- Deletes the original `.png` and `.jpg` files to free up storage.

## Warning

This program will delete the original `.png` and `.jpg` files after converting them to `.webp`. Ensure you have backups of your original images before running this program.

## Contributing

Contributions to improve this program are welcome. Please feel free to fork the repository, make your changes, and submit a pull request.

## License
This project is licensed under the MIT License - see the LICENSE file for details.
