#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

void problem1()
{
	int x = 20;
	int y = 10;

	printf("�� ���� ��: %d \n", x + y);
	printf("�� ���� ��: %d \n", x - y);
	printf("�� ���� ��: %d \n", x * y);
	printf("�� ���� ��: %d \n", x / y);
	
	printf("\n\n\n");
}

void problem2()
{
	float num1;
	float num2;

	printf("ù��° ���ڸ� �Է��ϼ���.: ");
	scanf("%f", &num1);
	printf("�ι�° ���ڸ� �Է��ϼ���.: ");
	scanf("%f", &num2);

	float sum = num1 + num2;

	printf("�� ���� ��: %f", sum);

	printf("\n\n\n");
}

void problem3()
{
	float radius;

	printf("�������� �Է��ϼ���.: ");
	scanf("%f", &radius);

	float area = radius * radius * 3.141592;

	printf("���� ����: %f", area);

	printf("\n\n\n");
}

void problem4()
{
	double width;
	double height;

	printf("�簢���� �ʺ� �Է��ϼ���.: ");
	scanf("%lf", &width);
	printf("�簢���� ���̸� �Է��ϼ���.: ");
	scanf("%lf", &height);

	double area = width * height;
	double perimeter = 2 * (width + height);

	printf("�簢���� ����: %lf", area);
	printf("�簢���� �ѷ�: %lf", perimeter);

	printf("\n\n\n");
}

void problem5() 
{
	float fahrenheit;

	printf("ȭ���µ��� �Է��ϼ���.: ");
	scanf("%f", &fahrenheit);

	float celsius = ((float)5 / (float)9) * (fahrenheit - 32);

	printf("�����µ�: %f", celsius);

	printf("\n\n\n");
}

int main()
{
	problem1();
	problem2();
	problem3();
	problem4();
	problem5();

	return 0;
}