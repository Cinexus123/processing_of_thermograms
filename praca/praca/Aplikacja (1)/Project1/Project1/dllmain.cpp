// dllmain.cpp : Definiuje punkt wejścia dla aplikacji DLL.
#include "stdafx.h"
#include <vector>
#include<algorithm>
#include <cmath>
#include <iomanip>
#include <iostream>
#include <complex>
#include <map>
using std::complex;
using std::exp;
using std::size_t;
using std::vector;
using std::cos;
using std::sin;
#define M_PI 3.14159265358979323846
using namespace std;
BOOL APIENTRY DllMain(HMODULE hModule,
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
//funkcja obliczająca pochodną sekwencji
extern "C" __declspec(dllexport)void DFT_AMP(double(&m)[], int W, int H, int Frames)
{

	vector<vector<vector<double>>>T3D;
	vector<vector<vector<double>>>T3D_res;
	vector<vector<double>> sumreal(W, vector<double>(H, 0));
	vector<vector<double>> sumimag(W, vector<double>(H, 0));
	vector<vector<vector<double>>>outreal;
	vector<vector<vector<double>>>outimag;
	int l = 0;
	for (int k = 0; k < Frames; k++)
	{
		vector<vector<double>> table;
		for (int i = 0; i < W; i++)
		{
			vector<double> row;
			for (int j = 0; j < H; j++)
			{
				row.push_back(m[l]);
				l++;
			}
			table.push_back(row);
		}
		T3D.push_back(table);
	}
	T3D_res = T3D;
	for (int l = 0; l < Frames; l++)
	{
		vector<vector<double>> sumreal(W, vector<double>(H, 0));
		vector<vector<double>> sumimag(W, vector<double>(H, 0));
		for (int i = 0; i < W; i++)
		{
			for (int j = 0; j < H; j++)
			{

				for (int k = 0; k < Frames; k++)
				{
					double angle = 2 * M_PI * k * l / Frames;
					sumreal[i][j] += T3D[k][i][j] * cos(angle);
					sumimag[i][j] += -T3D[k][i][j] * sin(angle);
				}
			}
		}
		outreal.push_back(sumreal);
		outimag.push_back(sumimag);
	}
	for (int l = 0; l < Frames; l++)
	{
		for (int i = 0; i < W; i++)
		{
			for (int j = 0; j < H; j++)
			{

				T3D_res[l][i][j] = sqrt(outreal[l][i][j] * outreal[l][i][j] + outimag[l][i][j] * outimag[l][i][j]);
				//T3D_res[l][i][j] = atan(outimag[l][i][j] / outreal[l][i][j]);
			}
		}
	}


	l = 0;
	for (int k = 0; k < Frames; k++)
	{
		for (int i = 0; i < W; i++)
		{
			for (int j = 0; j < H; j++)
			{
				m[l] = T3D_res[k][i][j];
				l++;
			}
		}
	}
}

