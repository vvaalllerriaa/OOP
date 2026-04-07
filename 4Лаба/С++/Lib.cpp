#include "Lib.h"
#include <cmath> 

ExpressionCalculator::ExpressionCalculator(double a_val, double b_val, double c_val, double d_val) {
    setValues(a_val, b_val, c_val, d_val);
}

void ExpressionCalculator::setValues(double a_val, double b_val, double c_val, double d_val) {
    a = a_val; b = b_val; c = c_val; d = d_val;
}

double ExpressionCalculator::calculateSqrt(double value) const {
    if (value < 0) {
        throw std::invalid_argument("Корінь від'ємного числа!");
    }
    return std::sqrt(value);
}

double ExpressionCalculator::calculateResult() const {
    if (b == 0) {
        throw std::runtime_error("Загальний знаменник є нулем!");
    }
    double sqrtPart = calculateSqrt(24.0 + d - c);

    double denominator = sqrtPart + (a / b);

    if (denominator == 0) {
        throw std::runtime_error("Загальний знаменник є нулем!");
    }
    double numerator = 1 + a - (b / 2.0);
    return numerator / denominator;
}