#include <wx/wx.h>

extern wxString appName;

class WA_D : public wxApp{
  public:
    virtual bool OnInit();
    virtual int OnExit();
};

DECLARE_APP(WA_D)
