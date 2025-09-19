#include "../libs/mainDlg.hpp"
#include "../libs/cclist.hpp"
#include "../libs/wa-api.hpp"

MainDlg::MainDlg()
          :wxDialog(nullptr, wxID_ANY, "WhatsApp Direct")
{
    // instantiate config file
    conf = wxConfig::Get();

    // create a number-only validator for mobile number input
    wxTextValidator mobVal(wxFILTER_DIGITS);

    // create 2 sizers
    headSizer = new wxBoxSizer(wxHORIZONTAL);
    mainSizer = new wxBoxSizer(wxVERTICAL);

    // create child controls
    ccChoice = new wxChoice(this, wxID_ANY);
    mobField = new wxTextCtrl(this, wxID_ANY, "", wxDefaultPosition, wxSize(150,-1), 0, mobVal);
    modeTgl = new wxToggleButton(this,wxID_ANY,"Desktop");
    goBtn = new wxButton(this, wxID_ANY, "Open WhatsApp");

    // set some stuff up, like values, limits, etc.
    mobField->SetHint("Mobile Number");
    mobField->SetMaxLength(10);

    // get vector's contents
    for(const auto & country : country_data){

      // create an item that'll keep a formatted version of the contents of a vector's value
      wxString dispItem = wxString::Format("%s (+%d)",country.second, country.first);

      // add the same to our list of choices
      ccChoice->Append(dispItem);
    }
    
    // get value stored in config
    mode = conf->ReadBool("/Mode/Desktop", false);
    
    // set the same value from config
    modeTgl->SetValue(mode);
    modeTgl->SetLabel((mode)?"Desktop":"Web");
    
    // create temp int
    int idx;
    
    // get value stored in config and save in temp int
    conf->Read("/Country/Index",&idx,0);
    
    // set selection to temp int
    ccChoice->SetSelection(idx);

    // add child controls to their respective sizers
    headSizer->Add(ccChoice, 0, wxALL, 2);
    headSizer->Add(mobField, 1, wxALL | wxEXPAND, 2);
    headSizer->Add(modeTgl, 0, wxALL, 2);
    mainSizer->Add(headSizer, 0, wxEXPAND | wxALL, 2);
    mainSizer->Add(goBtn, 0, wxEXPAND | wxALL, 2);

    // bind child controls to their respective events
    modeTgl->Bind(wxEVT_TOGGLEBUTTON, &MainDlg::onModeToggle, this);
    goBtn->Bind(wxEVT_BUTTON, &MainDlg::goClicked, this);

    // add the main sizer to the dialog
    this->SetSizerAndFit(mainSizer);
}

void MainDlg::onModeToggle(wxCommandEvent & evt) {
  
  // set the current value to the var
  mode = evt.IsChecked();
  
  // change button label according to state
  modeTgl->SetLabel((mode)?"Desktop":"Web");
  
  // write the same var to app config
  conf->Write("/Mode/Desktop",mode);
  
  // save config
  conf->Flush();
}

void MainDlg::goClicked(wxCommandEvent & evt) {

  // write current selection's index to config for future reference
  conf->Write("/Country/Index", ccChoice->GetSelection());

  // create a unified var that contains code + mobile number altogether
  std::string number = std::to_string(country_data[ccChoice->GetSelection()].first) + mobField->GetValue().ToStdString();

  // call my custom api
  WA_D_CALL(mode, number);

  // save config
  conf->Flush();

  // clear input
  mobField->SetValue("");
}
