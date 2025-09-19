#include "libs/app.hpp"
#include "libs/mainDlg.hpp"

wxIMPLEMENT_APP(WA_D);

bool WA_D::OnInit(){
  SetAppName("WhatsApp Direct");
  SetAppDisplayName("Whatsapp Direct");
  SetVendorName("SANeX");
  SetVendorDisplayName("SANeX");

  wxConfig::Set(new wxFileConfig(
    GetAppName(),
    GetVendorName(),
    wxEmptyString,
    wxEmptyString,
    wxCONFIG_USE_LOCAL_FILE | wxCONFIG_USE_GLOBAL_FILE
  ));

  MainDlg * md = new MainDlg();
  md->ShowModal();
  md->Destroy();
  return true;
}

int WA_D::OnExit(){
  delete wxConfig::Get();
  wxConfig::Set(nullptr);
  return 0;
}
