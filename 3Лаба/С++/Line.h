#ifndef WORDLINE_H
#define WORDLINE_H
#include <string>
#include <vector>

class WordLine {
private:
    std::string _content;
public:
    WordLine(std::string content);
    std::string getContent() const;
    void capitalize();
};

#endif