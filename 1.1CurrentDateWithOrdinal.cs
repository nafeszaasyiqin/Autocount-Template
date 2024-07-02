// Current date with ordinal format 

using System.Globalization;
using System.Windows.Forms;


private void label3_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
       DateTime currentDate = DateTime.Now;

    // Format the date to the custom format
    label3.Text = FormatDateWithOrdinal(currentDate);
}

private string FormatDateWithOrdinal(DateTime date) {
    string day = date.Day.ToString();
    string suffix = GetOrdinalSuffix(date.Day);
    string formattedDate = date.ToString("MMM ", CultureInfo.InvariantCulture) + day + suffix + date.ToString(", yyyy", CultureInfo.InvariantCulture);
    return formattedDate;
}

private string GetOrdinalSuffix(int day) {
    if (day >= 11 && day <= 13) {
        return "th";
    }
    switch (day % 10) {
        case 1: return "ˢᵗ";
        case 2: return "ⁿᵈ";
        case 3: return "ʳᵈ";
        default: return "ᵗʰ";
    }
 
} 
