#include "libs/app.hpp"
#include "libs/mainFrame.hpp"

wxString appName = "WhatsApp Direct";

wxIMPLEMENT_APP(WA_D);

bool WA_D::OnInit(){
  MainFrame * mf = new MainFrame();
  mf->Show();
  return true;
}
