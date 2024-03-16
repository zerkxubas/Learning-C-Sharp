using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Quiz : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Get text from TextBox
        string enteredText = txtInput.Text;

        // Get selected RadioButton option
        string selectedOption = rbOptions.SelectedItem != null ? rbOptions.SelectedItem.Text : "Not selected";

        // Check Checkbox state
        string agreeText = chkAgree.Checked ? "Student Status" : "Not selected";

        // Display the entered and selected items
        lblResult.Text = $"Full Name: {enteredText}<br />Gender: {selectedOption}<br />Student Status: {agreeText}";
    }
}