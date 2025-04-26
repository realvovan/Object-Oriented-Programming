#pragma once

class IWhiteSpaceRemover {
public:
    virtual void RemovePrefixWhiteSpace() = 0;
    virtual void RemovePostfixWhiteSpace() = 0;
    virtual void RemoveExtraSpaces() = 0;
};