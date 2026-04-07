#include <iostream>
#include <vector>   
#include "Lib.h" 

int main() {
    std::vector<ExpressionCalculator> list;
    
    list.push_back(ExpressionCalculator(10, 2, 5, 1));    
    list.push_back(ExpressionCalculator(5, 0, 10, 10));  
    list.push_back(ExpressionCalculator(1, 1, 100, 1));  

    std::cout << "Почати розрахунок" << std::endl;

    for (int i = 0; i < list.size(); i++) {
        std::cout << "Об'єкт #" << i + 1 << ": ";
        
        try {
            double res = list[i].calculateResult();
            std::cout << "Ваш результат = " << res << std::endl;
        } 
        catch (const std::exception& e) {
            std::cout << "Помилка: " << e.what() << std::endl;
        }
    }

    return 0;
}