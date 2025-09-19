#include "wx/sizer.h"
#include<wx/wx.h>

class MainFrame : public wxFrame {
  public:
    MainFrame();
  private:
    wxBoxSizer * mainSizer;
    wxChoice * ccChoice;
    wxTextCtrl * mobField;
    wxButton * goBtn;
};
