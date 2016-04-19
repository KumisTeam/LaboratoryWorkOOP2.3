#include "stdafx.h"
#include "Letter.h"


Letter::Letter()
{
}


Letter::~Letter()
{
}

Letter::Letter(string usrStr)
{
	for (int i = 0; i < usrStr.size(); i++)
		letters.push_back(usrStr[i]);
}

int Letter::GetSize()
{
	return letters.size();
}

void Letter::Show()
{
	for each (int var in letters)
		cout << var;
	cout << endl;
}

void Letter::DeleteSmth()
{
	for (int i = 0; i < letters.size() - 1; i++)
		if (letters[i] == 'a')
			swap(letters[i], letters[i + 1]);
	letters.pop_back();
	for (int i = 0; i < letters.size() - 1; i++)
		if (letters[i] == 'a')
			DeleteSmth();
	Show();
}

