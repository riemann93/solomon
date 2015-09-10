#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int		main(void){
	
	int Game_state = 1;	
		int board[4][4],i,j;
		
		for (i = 0; i <= 3; i++	){
			for (j = 1; j <= 4; j++ ){
				board[i][j] = 0;
			}
		}
		
		srand(time(NULL));
		int rand_numb = (rand() % 2) + 1;
		int rand_x = (rand() % 4);
		int rand_y = (rand() % 5) + 1;
		board[2][2] = rand_numb;
		
		for (i = 0; i < 4; i++){
		printf("| %d  %d  %d  %d |\n",board[i][1],board[i][2],board[i][3],board[i][4]);
		}
		I will fuck this script up
		
		
		
		
		int xit = 1; 
		while (xit == 1){
			char ans;
			printf("do you want to continue? (Y) / (N)\n");
			scanf("%c/n",&ans);
			if (ans == 'Y'){
				system("cls");
				printf("\nlets try again then\n");
				xit = 0;
			}else if(ans == 'N'){
				xit = 0;
				Game_state = 0;
			}else{
				printf("\nINVALID character... please use (Y) or (N)\n");
			}
		}
		return 0;
}
