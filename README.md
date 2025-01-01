# AES Encryption/Decryption Tool

A simple Windows Forms application that allows you to encrypt and decrypt text using the **AES (Advanced Encryption Standard)** algorithm. 
This tool is designed to help users understand and interact with encryption in an easy-to-use visual interface.

---

## Features
- **Encrypt Text**: Input plain text and a key to encrypt the data.
- **Decrypt Text**: Provide the encrypted text and the same key to decrypt back to the original plain text.
- **User-Friendly Interface**: Simple and clean Windows Forms UI.
- **Error Handling**: Validates user input and provides clear error messages for invalid keys or inputs.

---

![Program](app.png)

---

### Prerequisites
- Windows Operating System
- **Visual Studio 2022** or later
- .NET 8

---

### Installation

1. **Clone repository:**
	- **https://github.com/bax082024/VisualAES.git**
2. Open the `VisualAES.sln` file in **Visual Studio**.
3. **Rebuild Project** and run.

---

### Use

1. **Encrypt Text:**
	- Enter your **Plain Text** into the input box.
	- Provide a secure **Key** (must be at least 16 characters for AES-128, 32 for AES-256).
	- Click the **Encrypt** button to generate the encrypted text.
	- Copy the encrypted text from the `Encrypted Text` box.

2. **Decrypt Text:**
	- Paste the encrypted text into the `Encrypted Text` box.
	- Provide the same **Key** used during encryption.
	- Click the **Decrypt** button to retrieve the original plain text.

---

