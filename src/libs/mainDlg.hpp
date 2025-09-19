#include <wx/wx.h>
#include <wx/tglbtn.h>
#include <wx/config.h>

class MainDlg : public wxDialog {
  public:
    MainDlg();
    void onModeToggle(wxCommandEvent & evt),
         goClicked(wxCommandEvent & evt);
         //choiceHandler(wxCommandEvent & evt);
  private:
    wxConfigBase * conf;
    wxBoxSizer * mainSizer,
               * headSizer;
    wxChoice * ccChoice;
    wxTextCtrl * mobField;
    wxToggleButton * modeTgl;
    wxButton * goBtn;
    bool mode;
};
