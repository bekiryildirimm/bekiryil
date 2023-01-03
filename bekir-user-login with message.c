#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<conio.h>
#include<time.h>
typedef struct message{
	char send[20];
	char rec[20];
	char mes[100];
	struct message *next2;
}message_t;
typedef struct profil{
	char ad[20];
	char soyad[20];
	int tc;
	char gender[6];
	char day[3];
	char month[20];
	char year[5];
	char nickp[30];
	int key;
}profil_t;
typedef struct member{
	char nick[30];
	char sifre[30];
	profil_t kisi;
	struct member *next;
}member_t;
void menu(){
	printf("1. Giris Yap\n");
	printf("2. Kayit ol\n");
	printf("3. Cikis yap\n");
}
void menu2(){
	printf("1. Bilgilerinizi Goruntuleyin\n");
	printf("2. Gelen Kutusu\n");
	printf("3. Mesaj Gonder\n");
	printf("4. Cikis Yap\n");
}
message_t *getmessage(){
	message_t *temp8;
	temp8=(message_t *)malloc(sizeof(message_t));
	printf("Alici:");
	scanf("%s",temp8->rec);
	getchar();
	printf("Mesaj:");
	gets(temp8->mes);
	return temp8;
}
void printmessage(message_t *temp8){
	printf("%s-%s\n",temp8->send,temp8->mes);
}
member_t *getmember(){
	member_t *temp5;
	int i=0;
	char x;
	temp5=(member_t *)malloc(sizeof(member_t));
	printf("Kullanici adini giriniz:");
	scanf("%s",temp5->nick);
	printf("Sifre Giriniz:");
	do{
		x=getch();
		if(x==13)
		{
			break;
		}
		else
		{
		
		temp5->sifre[i]=x;
		printf("*");
		i++;
	    }
	}while(1);
	temp5->sifre[i]='\0';
	return temp5;
} 
member_t *getkisi(){
	member_t *temp2;
	temp2=(member_t *)malloc(sizeof(member_t));
	int i=0,y=1;
	char a[3],b[3],c[5],z;
	char ay[12][20]={"ocak","subat","mart","nisan","mayis","haziran","temmuz","agustos","eylul","ekim","kasim","aralik"};
	printf("\nAd ve Soyad:");
	scanf("%s %s",temp2->kisi.ad,temp2->kisi.soyad);
	printf("Tc No:");
	scanf("%d",&temp2->kisi.tc);
	printf("Cinsiyet:");
    scanf("%s",temp2->kisi.gender);
    printf("Dogum Tarihi (GG/AA/YYYY):");
    do{
		z=getch();
		if(z==13)
		{
			break;
		}
		else
		{ 
			if(i==0)
			{
				a[0]=z;
				printf("%c",z);
			}
			
		   	else if(i==1)
			{
			   a[1]=z;
				printf("%c",z);
			}
		
		else if(i==2)
			{   
			     b[0]=z;
				printf("/%c",z);
			}
			else if(i==3)
			{
				b[1]=z;
				printf("%c",z);
			}
			
			else if(i==4)
			{ 
			c[0]=z;
				printf("/%c",z);
			}
			else{
				c[y++]=z;
				printf("%c",z);
			}
			i++;
			
		}
	  }while(z!=13);
	  a[2]='\0';
    if(a[0]==48)
    {
    	temp2->kisi.day[0]=a[1];
	}
	else
	{
		temp2->kisi.day[0]=a[0];
		temp2->kisi.day[1]=a[1];
		temp2->kisi.day[2]='\0';
	}
	i=0;
	  while(i<12){
	     if(b[0]==48)
	     {
		 
	  	if(b[1]-49==i){
	       strcpy(temp2->kisi.month,ay[i]);
	  		break;
		  } 
     	}
		  else if(b[0]==49)
		  {
		  	if(b[1]-39==i){
	       strcpy(temp2->kisi.month,ay[i]);
	  		break;
		  }
		  } 
		  i++;
	  }
	  c[4]='\0';
	  strcpy(temp2->kisi.year,c);
    return temp2;
}
void printmember(member_t *temp){
	printf("%s %s\n",temp->nick,temp->sifre);
}
void printkisi(member_t *temp2){
	printf("%s %s %d %s %s %s %s\n",temp2->kisi.ad,temp2->kisi.soyad,temp2->kisi.tc,temp2->kisi.gender,temp2->kisi.day,temp2->kisi.month,temp2->kisi.year);
}
void printinfo(member_t *temp2){
	printf("AD:%s\nSoyad:%s\nTc Kimlik No:%d\nCinsiyet:%s\nDogum Tarihi:%s %s %s\n",temp2->kisi.ad,temp2->kisi.soyad,temp2->kisi.tc,temp2->kisi.gender,temp2->kisi.day,temp2->kisi.month,temp2->kisi.year);
}
char *encodenick(char *nick){
	int i,y=64;
	for(i=0;nick[i]!='\0';i++){
		nick[i]=nick[i]-y--;
	}
	return nick;
}
char *decodenick(char *nick){
	int i,y=64;
	for(i=0;nick[i]!='\0';i++){
		nick[i]=nick[i]+y--;
	}
	return nick;
}
char *encodesifre(char *sifre){
	int i,y=43;
	for(i=0;sifre[i]!='\0';i++){
		sifre[i]=sifre[i]-y++;
	}
	return sifre;
}
char *decodesifre(char *sifre){
	int i,y=43;
	for(i=0;sifre[i]!='\0';i++){
		sifre[i]=sifre[i]+y++;
	}
	return sifre;
}
char *encodead(char *ad,int k){
	int i,y=1;
	k=k-11;
	for(i=0;ad[i]!='\0';i++){
		ad[i]=ad[i]-k+y++;
	}
	return ad;
}
char *decodead(char *ad,int k){
	int i,y=1;
	k=k-11;
	for(i=0;ad[i]!='\0';i++){
		ad[i]=ad[i]+k-y++;
	}
	return ad;
}
char *encodesoyad(char *soyad,int k){
	int i,y=1;
	k=k-23;
	for(i=0;soyad[i]!='\0';i++){
		soyad[i]=soyad[i]-k+y++;
	}
	return soyad;
}
char *decodesoyad(char *soyad,int k){
	int i,y=1;
	k=k-23;
	for(i=0;soyad[i]!='\0';i++){
		soyad[i]=soyad[i]+k-y++;
	}
	return soyad;
}
char *encodeinfo(char *info,int k){
	int i,y=1;
	k=k-40;
	for(i=0;info[i]!='\0';i++){
		info[i]=info[i]-k+y++;
	}
	return info;
}
char *decodeinfo(char *info,int k){
	int i,y=1;
	k=k-40;
	for(i=0;info[i]!='\0';i++){
		info[i]=info[i]+k-y++;
	}
	return info;
}
char *encodedate(char *date){
	int i,y=18;
	for(i=0;date[i]!='\0';i++){
		date[i]=date[i]+y--;
	}
	return date;
}
char *decodedate(char *date){
	int i,y=18;
	for(i=0;date[i]!='\0';i++){
		date[i]=date[i]-y--;
	}
	return date;
}
int main(){
	int secim,j,secim2,c;
	char nick1[30],sifre1[30],k;
	member_t *start=NULL,*temp,*kayit,*prev,*start1=NULL,*temp4,*temp5;
	message_t *start3=NULL,*temp8,*kayit2,*prev2,*temp9;
	srand(time(NULL));
	FILE *logp;
	if((logp=fopen("login2.txt","r"))==NULL)
	{
		printf("login file Acilamadi..\n");
	}
	else
	{
		while(1){
			temp4=(member_t *)malloc(sizeof(member_t));
			fscanf(logp,"%s %s",temp4->nick,temp4->sifre);
			if(feof(logp))
			{
				break;
			}
			else
			{    decodenick(temp4->nick);
			     decodesifre(temp4->sifre);
				if(start==NULL)
				{
                  start=temp4;
                  temp4->next=NULL;
				}
				else
				{
                  temp=start;
                  prev=NULL;
                  while(temp!=NULL&&strcmp(temp->nick,temp4->nick)<0){
                  	prev=temp;
                  	temp=temp->next;
				  }
				  if(prev==NULL)
				  {
				  	temp4->next=start;
				  	start=temp4;
				  }
				  else
				  {
				  	prev->next=temp4;
				  	temp4->next=temp;
				  }
				}
				}
			
		} fclose(logp);
	} 
	FILE *infop;
	if((infop=fopen("userinfo2.txt","r"))==NULL)
	{
		printf("userinfo file acilamadi..\n");
	}
	else
	{
		while(1){
			temp5=(member_t *)malloc(sizeof(member_t));
			fscanf(infop,"%s %s %d %s %s %s %s %s %c",temp5->kisi.ad,temp5->kisi.soyad,&temp5->kisi.tc,temp5->kisi.gender,temp5->kisi.day,temp5->kisi.month,temp5->kisi.year,temp5->kisi.nickp,&temp5->kisi.key);
			if(feof(infop))
			{
				break;
			}
			else
			{ 
			     decodead(temp5->kisi.ad,temp5->kisi.key);
			     decodesoyad(temp5->kisi.soyad,temp5->kisi.key);
			     decodeinfo(temp5->kisi.gender,temp5->kisi.key);
			     decodedate(temp5->kisi.day);
			     decodeinfo(temp5->kisi.month,temp5->kisi.key);
			     decodedate(temp5->kisi.year);
			     decodeinfo(temp5->kisi.nickp,temp5->kisi.key);
				if(start1==NULL)
				{
					start1=temp5;
					temp5->next=NULL;
				}
				else
				{
					temp=start1;
					prev=temp;
						while(temp!=NULL&&strcmp(temp->kisi.nickp,temp5->kisi.nickp)<0){
												prev=temp;
												temp=temp->next;
											}
											if(prev==NULL){
												temp5->next=start1;
												start1=temp5;
											}
											else{
												prev->next=temp5;
												temp5->next=temp;
											}
				}
			}
		} fclose(infop);
	}
	FILE *mesp;
	if((mesp=fopen("inbox.txt","r"))==NULL)
	{
		printf("inbox file acilamadi..\n");
	}
	else
	{
		while(1)
	      {
	      	temp9=(message_t *)malloc(sizeof(message_t));
	      	fscanf(mesp,"%s %s",temp9->send,temp9->rec);
	      	fscanf(mesp,"\n");
	      	fgets(temp9->mes,100,mesp);
	      	if(feof(mesp))
	      	{
	      		break;
			  }
			  else
			  {
			  	if(start3==NULL)
					{
					start3=temp9;
				    temp9->next2=NULL;
							}
							else
							{
						temp8=start3;
						prev2=NULL;
						while(temp8!=NULL&&strcmp(temp8->rec,temp9->rec)<0)
						{
						prev2=temp8;
						temp8=temp8->next2;
						}
						if(prev2==NULL)
						{
					    temp9->next2=start3;
						start3=temp9;
							}
						else
						{
						prev2->next2=temp9;
						temp9->next2=temp8;
						}
							}
							/*if(start3==NULL)
							{
								start3=temp9;
								temp9->next2=NULL;
							}
							else
							{
								temp8=start3;
								while(temp8->next2!=NULL)
								{
									temp8=temp8->next2;
									temp8->next2=temp9;
									temp9->next2=NULL;
								}
							} sona ekleme ile olmuyor */  
			  }
		  } fclose(mesp);
	}
	do{
		menu();
		scanf("%d",&secim);
		system("cls");
		
		switch(secim)
		{
			case 1:
				printf("Kullanici adiniz:");
				scanf("%s",nick1);
				printf("Sifreniz:");
				j=0;
				do{
					k=getch();
					if(k==13)
					{
						break;
					}
					else
					{
					sifre1[j]=k;
					printf("*");
					j++;
				    }
				}while(1);
				sifre1[j]='\0';
				temp=start;
				while(temp!=NULL&&strcmp(temp->nick,nick1)!=0){
					temp=temp->next; }
					if(temp==NULL) {
						printf("\nKullanici adi hatali:\n");
						getch();				
				system("cls");
					}
					else {
							if(strcmp(temp->sifre,sifre1)==0){
											if(start1!=NULL){
												temp=start1;
											while(temp->next!=NULL&&strcmp(temp->kisi.nickp,nick1)!=0){
												temp=temp->next;
											} } 
								if(strcmp(temp->kisi.nickp,nick1)!=0){
									kayit=getkisi();
										strcpy(kayit->kisi.nickp,nick1);
										kayit->kisi.key=rand()%88+7;
										if(start1==NULL){
											start1=kayit;
											kayit->next=NULL;
										}
										else{
											temp=start1;
											prev=NULL;
											while(temp!=NULL&&strcmp(temp->kisi.nickp,kayit->kisi.nickp)<0){
												prev=temp;
												temp=temp->next;
											}
											if(prev==NULL){
												kayit->next=start1;
												start1=kayit;
											}
											else{
												prev->next=kayit;
												kayit->next=temp;
											}
										} 
									system("cls");	}
										else if(strcmp(temp->kisi.nickp,nick1)==0){
											printf("\n");
											do{ 
												menu2();
												scanf("%d",&secim2);
												system("cls");
												switch(secim2)
												{
													case 1:
														printf("Kisisel Bilgileriniz:\n"); 
											            printinfo(temp);
											            getch();
											            system("cls");
											            break;
											        case 2:
											        if(start3!=NULL)
											        {
											        	temp8=start3;
											        	while(temp8->next2!=NULL&&strcmp(temp8->rec,nick1)!=0)
											        	{
											        		temp8=temp8->next2;
														}
														if(strcmp(temp8->rec,nick1)!=0)
														{
															printf("Gelen Kutusu Bos..");
														}
														else if(strcmp(temp8->rec,nick1)==0)
														{   
														    //printmessage(temp8);
															//ptr=temp8;
															temp8=start3;
															while(temp8!=NULL)
															{ 
															if(strcmp(temp8->rec,nick1)==0)
															{
																printmessage(temp8);
															}
															temp8=temp8->next2;
															}
														}
													}
													else
													{
														printf("Gelen Kutusu Bos..!");
													}
													getch();
													system("cls");
													break;
													case 3:
														kayit2=getmessage();
														strcpy(kayit2->send,nick1);
														if(start3==NULL)
														{
															start3=kayit2;
															kayit2->next2=NULL;
														}
														else
														{
															temp8=start3;
															prev2=NULL;
															while(temp8!=NULL&&strcmp(temp8->rec,kayit2->rec)<0)
															{
																prev2=temp8;
																temp8=temp8->next2;
															}
															if(prev2==NULL)
															{
																kayit2->next2=start3;
																start3=kayit2;
															}
															else
															{
																prev2->next2=kayit2;
																kayit2->next2=temp8;
															}
														} 
				                                        break;
														case 4:
															break;
															default:
																printf("Yanlis islem..");
																break;
												}
											}while(secim2!=4);
											
										//	printf("\nKisisel Bilgileriniz:\n"); 
										//	printinfo(temp);
										
										} }
							else{
								printf("\nSifre Yanlis! Tekrar Deneyiniz:\n");
						
						}
					}
				break;
				case 2: /*sorun burada..*/
			kayit=getmember(); 
				if(start==NULL){
					start=kayit;
					kayit->next=NULL;
				}
				else{
					temp=start;
					prev=NULL;
					while(temp->next!=NULL&&strcmp(temp->nick,kayit->nick)<0){
						prev=temp;
						temp=temp->next;
					}
					if(strcmp(temp->nick,kayit->nick)==0){
						printf("\nKullanici adi mevcuttur!\nTekrar Deneyiniz..");
						getch(); }
						else{
					if(prev==NULL){
						kayit->next=start;
						start=kayit;
					}
					else{
						prev->next=kayit;
						kayit->next=temp;
					}
				} }
				system("cls");
				break;
				case 3:
					break;
					case 4:
					temp=start;
					while(temp!=NULL){
						printmember(temp);
						temp=temp->next;}
						break;
						case 5:
							temp=start1;
											while(temp!=NULL){
												printkisi(temp);
												temp=temp->next;
											}
											break;
					default:
						printf("Yanlis islem sectiniz:\n");
						break;
		}
	}while(secim!=3);
	if(start!=NULL)
	{
		FILE *logf;
		if((logf=fopen("login2.txt","w"))==NULL)
		{
			printf("login file acilamadi..!\n");
		}
		else
		{    temp=start;
			while(temp!=NULL){
				fprintf(logf,"%s %s\n",encodenick(temp->nick),encodesifre(temp->sifre));
				temp=temp->next;
			}
			fclose(logf);
		}
	}
	if(start1!=NULL)
	{
		FILE *infof;
		if((infof=fopen("userinfo2.txt","w"))==NULL)
		{
			printf("userinfo file acilamadi..!\n");
		}
		else
		{
			temp=start1;
			while(temp!=NULL){
				fprintf(infof,"%s %s %d %s %s %s %s %s %c\n",encodead(temp->kisi.ad,temp->kisi.key),encodesoyad(temp->kisi.soyad,temp->kisi.key),temp->kisi.tc,encodeinfo(temp->kisi.gender,temp->kisi.key),encodedate(temp->kisi.day),encodeinfo(temp->kisi.month,temp->kisi.key),encodedate(temp->kisi.year),encodeinfo(temp->kisi.nickp,temp->kisi.key),temp->kisi.key);
				temp=temp->next;
			}
			fclose(infof);
		}
	 } 
	 if(start3!=NULL)
	 {
	 	FILE *mesf;
	 	if((mesf=fopen("inbox.txt","w"))==NULL)
	 	{
	 		printf("inbox file acilamadi..\n");
		 }
		 else
		 {
		 	temp8=start3;
		 	while(temp8!=NULL)
		 	{
		 		fprintf(mesf,"%s %s %s\n",temp8->send,temp8->rec,temp8->mes);
		 		temp8=temp8->next2;
			 }
			 fclose(mesf);
		 }
	 }
	} 
