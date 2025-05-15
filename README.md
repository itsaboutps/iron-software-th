# 📱 Old Phone Pad Coding Challenge

This project is a solution to the **Old Phone Pad** C# coding challenge. It simulates typing on a classic mobile phone keypad where each number key corresponds to one or more letters.

---

## ✅ Challenge Description

You're given a string of input characters that simulate keypresses on an old mobile phone keypad. Your task is to interpret the sequence and return the intended output text.

### Key Features:
- Each number key (2–9) represents a group of letters.
- Pressing a number multiple times cycles through its letters.
- A **pause** (represented by a space `' '`) separates sequences from the same key.
- A **backspace** is represented by `*`, which removes the last character typed.
- A **send** is represented by `#`, which terminates the input and signals the end.

---

## 🎯 Example Inputs and Expected Outputs

| Input                        | Output          |
|------------------------------|-----------------|
| `33#`                        | `E`             |
| `227*#`                      | `B`             |
| `4433555 555666#`            | `HELLO`         |
| `8 88777444666*664#`         | `????`          |
| `777733 6660 5556660966...#` | `SECRETMESSAGE` |

---

## 🛠 How to Run

### Requirements:
[.NET SDK](https://dotnet.microsoft.com/download) (.NET Core or .NET 6+)

### Clone the Repository


git clone https://github.com/your-username/OldPhonePad.git
cd OldPhonePad

---

# Run the Console App
dotnet run --project OldPhonePad


Then, enter your input string (ending with #), e.g.: 4433555 555666#

---

🧪 Running Unit Tests: This project includes unit tests written with xUnit.
# Run the command 
dotnet test

