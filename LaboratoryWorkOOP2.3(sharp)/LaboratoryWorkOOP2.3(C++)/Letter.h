#pragma once
#include "Row.h"
#include <vector>
#include <iostream>

using namespace std;
class Letter :
	public Row
{
private:
	vector<char>letters;
public:
	Letter();
	~Letter();

	Letter(string usrStr);

	void DeleteSmth() override;
	void Show() override;
	int GetSize() override;
};

