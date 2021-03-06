// dllmain.cpp : Definiuje punkt wejścia dla aplikacji DLL.
#include "stdafx.h"
#include <vector>
#include <algorithm>
#define PI 3.141592
using namespace std;
BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}
//funkcja zamieniająca obraz na jego negatyw
extern "C" __declspec(dllexport) void DFT_PHR(double m[], int W, int H)
{
	// set standard deviation to 1.0
	double sto = 100;
	int bialy = 0;
	int czarny = 0;
	double procent;
	vector<vector<double>>T2D;
	int k = 0;
	for (int i = 0; i < W; i++)
	{
		vector<double>row;

		for (int j = 0; j < H; j++)
		{
			row.emplace_back(m[k]);
			k++;
		}
		T2D.emplace_back(row);
	}
	for (int i = 0; i < W; i++)
	{
		for (int j = 0; j < H; j++)
		{
			if (T2D[i][j] == 255)
				bialy++;
			if (T2D[i][j] == 0)
				czarny++;
			if (bialy > czarny)
			{
				double wynik=(czarny / H * W)*log2(czarny / H * W) + (bialy / H * W)*log2(bialy / H * W);
				
			}
		}
	}
	k = 0;
	for (int i = 0; i < W; i++)
	{
		for (int j = 0; j < H; j++)
		{
			m[k] = T2D[i][j];
			k++;
		}
	}
	
	
}
