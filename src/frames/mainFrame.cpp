#include "../libs/mainFrame.hpp"
#include "wx/sizer.h"

MainFrame::MainFrame()
          :wxFrame()
{
    mainSizer = new wxBoxSizer(wxVERTICAL);

    ccChoice = new wxChoice(this, wxID_ANY);
    mobField = new wxTextCtrl(this, wxID_ANY);
    goBtn = new wxButton(this, wxID_ANY, "Open ->");

    mainSizer->Add(ccChoice, 0, wxALL, 10);
    mainSizer->Add(mobField, 0, wxALL | wxEXPAND, 10);
    mainSizer->Add(goBtn, 0, wxALL, 10);

    this->SetSizerAndFit(mainSizer);
}
