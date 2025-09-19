#include "../libs/mainDlg.hpp"
#include "../libs/cclist.hpp"
#include "../libs/wa-api.hpp"

MainDlg::MainDlg()
          :wxDialog(nullptr, wxID_ANY, "WhatsApp Direct")
{
    conf = wxConfig::Get();
    wxTextValidator mobVal(wxFILTER_DIGITS);
    
    headSizer = new wxBoxSizer(wxHORIZONTAL);
    mainSizer = new wxBoxSizer(wxVERTICAL);

    ccChoice = new wxChoice(this, wxID_ANY);
    mobField = new wxTextCtrl(this, wxID_ANY, "", wxDefaultPosition, wxSize(150,-1), 0, mobVal);
    modeTgl = new wxToggleButton(this,wxID_ANY,"Desktop");
    goBtn = new wxButton(this, wxID_ANY, "Open ->");

    mobField->SetHint("Mobile Number");
    for(const auto & country : country_data){
      wxString dispItem = wxString::Format("%s (+%d)",country.second, country.first);
      ccChoice->Append(dispItem);
    }

    int idx = conf->Read("/Country/Index",0);
    ccChoice->SetSelection(idx);

    headSizer->Add(ccChoice, 0, wxALL, 2);
    headSizer->Add(mobField, 1, wxALL | wxEXPAND, 2);
    headSizer->Add(modeTgl, 0, wxALL, 2);
    mainSizer->Add(headSizer, 0, wxEXPAND | wxALL, 2);
    mainSizer->Add(goBtn, 0, wxEXPAND | wxALL, 2);

    modeTgl->Bind(wxEVT_TOGGLEBUTTON, &MainDlg::onModeToggle, this);
    
    this->SetSizerAndFit(mainSizer);
}

void MainDlg::onModeToggle(wxCommandEvent & evt) {
  conf->Write("/Mode/Desktop",evt.IsChecked());
  conf->Flush();
}

void MainDlg::goClicked(wxCommandEvent & evt) {
  conf->Write("/Country/Index", ccChoice->GetSelection());
  std::string number = std::to_string(country_data[ccChoice->GetSelection()].first) + mobField->GetValue().ToStdString();
  WA_D_CALL(mode, number);
  conf->Flush();
}
