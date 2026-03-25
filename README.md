# CyrillicConverter – Word Add-in for Cyrillic Conversion

## Overview

CyrillicConverter is a Microsoft Word add-in developed using C# and VSTO that enables efficient and intelligent conversion of Latin text to Cyrillic.

The add-in provides multiple execution modes, including an advanced automatic mode that dynamically selects the optimal processing strategy based on text size and system performance.

Text conversion between Latin and Cyrillic scripts is a common requirement in multilingual environments, especially in regions where both scripts are actively used.

This tool simplifies that process directly inside Microsoft Word, eliminating the need for external converters and improving workflow efficiency.

It is particularly useful for:

- students and academic writing
- administrative and official documents

Additionally, the implementation of multiple execution modes demonstrates how performance can be optimized in real-world applications, making this project not only practical but also technically relevant.

---

## Features

* **Three execution modes:**

  * Sequential – simple and reliable processing
  * Parallel – faster processing using multithreading
  * Automatic – selects the best mode based on performance
* 🧠 **Smart digraph handling**

  * Correct conversion of *lj, nj, dž*
  * Handles edge cases and exceptions
* **Performance optimization**

  * Improved speed for large texts
* **Microsoft Word integration**

  * Custom ribbon with user controls

---

## Technologies Used

* **C#**
* **.NET**
* **VSTO (Visual Studio Tools for Office)**
* **Microsoft Word Object Model**

---

## How It Works

The application processes text from the active Word document and converts it into Cyrillic using predefined mapping rules.

* In **sequential mode**, characters are processed one by one.
* In **parallel mode**, the text is split into segments and processed concurrently.
* In **automatic mode**, the system:

  * analyzes text length
  * evaluates performance conditions
  * selects the most efficient approach

---

## Getting Started

### Prerequisites

* Microsoft Word
* .NET Framework / .NET compatible with VSTO
* Visual Studio with Office/SharePoint development tools

### Running the Project

1. Clone the repository:

   ```bash
   git clone https://github.com/elez-n/CyrillicConverter.git
   ```

2. Open the solution in Visual Studio

3. Build and run the project

4. Microsoft Word will start with the add-in enabled

---

## Author

Developed by **Natasa Elez**

---

## Notes

This project demonstrates:

* practical use of multithreading
* performance-aware application design
* integration with Microsoft Office tools

---

