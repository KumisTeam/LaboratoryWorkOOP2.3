#pragma once
#include "Row.h"
#include <vector>
#include <iostream>

using namespace std;
class Digit :
	public Row
{
private:
	vector<int> digits;
public:
	Digit();
	~Digit();

	Digit(string usrStr);
	
	void DeleteSmth() override;
	void Show() override;
	int GetSize() override;
	
};

