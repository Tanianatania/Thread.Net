import { Component, Input, OnDestroy } from '@angular/core';
import { Post } from 'src/app/models/post/post';
import { AuthenticationService } from 'src/app/services/auth.service';
import { AuthDialogService } from 'src/app/services/auth-dialog.service';
import { empty, Observable, Subject } from 'rxjs';
import { DialogType } from 'src/app/models/common/auth-dialog-type';
import { LikeService } from 'src/app/services/like.service';
import { DisLikeService } from 'src/app/services/dislike.service';
import { NewComment } from 'src/app/models/comment/new-comment';
import { CommentService } from 'src/app/services/comment.service';
import { User } from 'src/app/models/user';
import { Comment } from 'src/app/models/comment/comment';
import { catchError, switchMap, takeUntil } from 'rxjs/operators';
import { SnackBarService } from 'src/app/services/snack-bar.service';

@Component({
    selector: 'app-comment',
    templateUrl: './comment.component.html',
    styleUrls: ['./comment.component.sass']
})
export class CommentComponent {
    @Input() public comment: Comment;
    @Input() public currentUser: User;

    private unsubscribe$ = new Subject<void>();

    public constructor(
        private authService: AuthenticationService,
        private authDialogService: AuthDialogService,
        private likeService: LikeService,
        private dislikeService: DisLikeService,
    ) { }


    public likeComment() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.likeService.likeComment(this.comment, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((comment) => (this.comment = comment));

            return;
        }

        this.likeService
            .likeComment(this.comment, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((comment) => (this.comment = comment));
    }

    public dislikeComment() {
        if (!this.currentUser) {
            this.catchErrorWrapper(this.authService.getUser())
                .pipe(
                    switchMap((userResp) => this.dislikeService.dislikeComment(this.comment, userResp)),
                    takeUntil(this.unsubscribe$)
                )
                .subscribe((comment) => (this.comment = comment));

            return;
        }

        this.dislikeService
            .dislikeComment(this.comment, this.currentUser)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((comment) => (this.comment = comment));
    }

    public openAuthDialog() {
        this.authDialogService.openAuthDialog(DialogType.SignIn);
    }

    private catchErrorWrapper(obs: Observable<User>) {
        return obs.pipe(
            catchError(() => {
                this.openAuthDialog();
                return empty();
            })
        );
    }
}
