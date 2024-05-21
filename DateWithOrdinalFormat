// To adjust date format become Date with Ordinal eg: 21ˢᵗ March, 2001

using System;  // Fundamental classes and base classes for .NET
using System.Globalization; // Classes for culture-related information (e.g., date formatting)
using System.ComponentModel; // Classes for component and control behavior, including event handling

private void label3_BeforePrint(object sender, CancelEventArgs e) {
    // Retrieve the date string from label3.Text
    string dateText = label3.Text;
    
    // Parse the date string to a DateTime object
    DateTime parsedDate;
    if (DateTime.TryParse(dateText, out parsedDate)) {
        // Format the date to the custom format
        label3.Text = FormatDateWithOrdinal(parsedDate);
    } else {
        // Handle the case where parsing fails (optional)
        // Can set a default value or show an error message
        label3.Text = "";
    }
}

private string FormatDateWithOrdinal(DateTime date) {
    string day = date.Day.ToString();
    string suffix = GetOrdinalSuffix(date.Day);
    string formattedDate = date.ToString("MMM ", CultureInfo.InvariantCulture) + day + suffix + date.ToString(", yyyy", CultureInfo.InvariantCulture);
    return formattedDate;
}

private string GetOrdinalSuffix(int day) {
   // Special case for days 11, 12, and 13
    if (day >= 11 && day <= 13) {
        return "ᵗʰ";
    }
    switch (day % 10) {
         case 1: return "ˢᵗ"; // 1st
        case 2: return "ⁿᵈ"; // 2nd
        case 3: return "ʳᵈ"; // 3rd
        default: return "ᵗʰ"; // 4th, 5th, ..., 20th, etc.
    }
}
