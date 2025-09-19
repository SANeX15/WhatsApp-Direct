#include "../libs/wa-api.hpp"

void WA_D_CALL(const bool mode, const std::string &contact){
  std::string url;
    if (mode) {
        url = "whatsapp://send?phone=" + contact;
    } else {
        url = "http://web.whatsapp.com/send?phone=" + contact;
    }
    
    #if defined(_WIN32)
        // For Windows, use ShellExecute
        ShellExecuteA(NULL, "open", url.c_str(), NULL, NULL, SW_SHOWNORMAL);
    #elif defined(__APPLE__)
        // For macOS, use the 'open' command
        std::string command = "open " + url;
        system(command.c_str());
    #elif defined(__linux__)
        // For Linux, use the 'xdg-open' command
        std::string command = "xdg-open " + url;
        system(command.c_str());
    #else
        // Fallback or error for unsupported platforms
        // You could print an error message here.
    #endif
}
