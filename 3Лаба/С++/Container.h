#ifndef TEXTCONTAINER_H
#define TEXTCONTAINER_H
#include "Line.h"
#include <vector>

class IKeyGenerator {
public:
    virtual std::string getKeyFromWords(std::string text) = 0;
    virtual ~IKeyGenerator() {}
};

class TextContainer : public IKeyGenerator {
private:
    std::vector<WordLine> _lines;
public:
    void addLine(std::string text);
    void removeLine(int index);
    void clear();
    void capitalizeAll();
    int countWithLength(int len);
        std::string getKeyFromWords(std::string text) override;
    
    const std::vector<WordLine>& getLines() const { return _lines; }
};

#endif