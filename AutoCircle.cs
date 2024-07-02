
/* AutoCount Stock Item Template
This repository contains a template for a new product specification form designed to automatically highlight selected data with a circle shape using a drag-and-drop feature combined with some coding behind it. 
This functionality eliminates the need for manual circling, streamlining the data selection process and improving efficiency.

Features
-Drag-and-Drop Interface: Easily select data by dragging and dropping.
-Auto Circle Highlight: Automatically highlights selected data with a circle.
-User-Friendly Design: Simple and intuitive interface for ease of use.
-Efficient Data Management: Enhances productivity by reducing manual work.
*/

using System.Text.RegularExpressions;

private void other_BeforePrint(object sender, System.ComponentModel.CancelEventArgs e) {
    // Get the text from other
    string UOM = other.Text;

    // Check if the text contains 'x'
    int indexOfX = UOM.IndexOf('x');
    
    
        if (indexOfX != -1) { // If 'x' is found
        // Extract the substring after 'x'
        string wordAfterX = UOM.Substring(indexOfX + 1).Trim();
       
        String substringAfterX = wordAfterX .TrimStart('0', '1', '2', '3', '4', '5', '6', '7', '8', '9');

        // Find the end index of the word (assuming it's until the next non-alphabetic character)
        int endIndex = substringAfterX.IndexOfAny(new char[] { '(', ')' });
    
        // Extract the word "tin"
        string enduom= endIndex != -1 ? substringAfterX.Substring(0, endIndex).Trim() : substringAfterX;               
                                   
        if (wordAfterX .Contains("pkt")){
        shape1.Visible= true;
        other.Text = "";}
        else if(wordAfterX .Contains("bag")){
        c2.Visible= true;
        other.Text = "";}
        else if(wordAfterX .Contains("tin")){
       c3.Visible= true;
       other.Text = "";}
       else if(wordAfterX .Contains("ctn")){
        c4.Visible= true;
        other.Text = "";}
       else if(wordAfterX .Contains("pcs")){
        c5.Visible= true;
        other.Text = "";}
        else if(wordAfterX .Contains("can")){
       c6.Visible= true;
       other.Text = "";}
       else if(wordAfterX .Contains("bottle")){
       c7.Visible= true;
       other.Text = "";}
       else if(wordAfterX .Contains("tray")){
       c8.Visible= true;
       other.Text = "";}
        else if(wordAfterX .Contains("box")){
       c9.Visible= true;
       other.Text = "";}
       else if(wordAfterX .Contains("cup")){
       c10.Visible= true;
       other.Text = "";}

       else 
       other.Text = enduom;
           
    }
    
   }
