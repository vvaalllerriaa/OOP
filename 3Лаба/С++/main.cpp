#include <iostream>
#include "Container.h"

int main() {
    TextContainer doc;
    doc.addLine("cpp is fast");
    doc.addLine("clean code");

    std::cout << "Key: " << doc.getKeyFromWords("very important string") << std::endl;

    doc.capitalizeAll();
    
    for (const auto& line : doc.getLines()) {
        std::cout << line.getContent() << std::endl;
    }

    return 0;
}