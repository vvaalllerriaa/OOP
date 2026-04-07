#pragma once 
#include <stdexcept> 

class ExpressionCalculator {
private:
    double a, b, c, d;
    double calculateSqrt(double value) const;

public:
    ExpressionCalculator(double a_val, double b_val, double c_val, double d_val);
    void setValues(double a_val, double b_val, double c_val, double d_val);
    double calculateResult() const;
};