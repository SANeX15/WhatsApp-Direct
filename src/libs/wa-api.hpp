#include <cstdlib>
#include <string>

// Include necessary headers for each platform
#if defined(_WIN32)
#include <windows.h>
#include <shellapi.h>
#elif defined(__APPLE__)
#include <unistd.h>
#elif defined(__linux__)
#include <unistd.h>
#endif

void WA_D_CALL(const bool mode, const std::string& contact);
