import { Injectable } from '@angular/core';
import { AuthenticationService } from './auth.service';
import { Post } from '../models/post/post';
import { Comment } from '../models/comment/comment';
import { NewDisReaction } from '../models/disreaction/newDisReaction';
import { PostService } from './post.service';
import { User } from '../models/user';
import { map, catchError } from 'rxjs/operators';
import { of } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class DisLikeService {
    public constructor(private authService: AuthenticationService, private postService: PostService) { }

    public dislikePost(post: Post, currentUser: User) {
        const innerPost = post;

        const reaction: NewDisReaction = {
            entityId: innerPost.id,
            isDisLike: true,
            userId: currentUser.id
        };

        // update current array instantly
        let hasReaction = innerPost.disReactions.some((x) => x.user.id === currentUser.id);
        innerPost.disReactions = hasReaction
            ? innerPost.disReactions.filter((x) => x.user.id !== currentUser.id)
            : innerPost.disReactions.concat({ isDisLike: true, user: currentUser });
        hasReaction = innerPost.disReactions.some((x) => x.user.id === currentUser.id);

        return this.postService.dislikePost(reaction).pipe(
            map(() => innerPost),
            catchError(() => {
                // revert current array changes in case of any error
                innerPost.disReactions = hasReaction
                    ? innerPost.disReactions.filter((x) => x.user.id !== currentUser.id)
                    : innerPost.disReactions.concat({ isDisLike: true, user: currentUser });

                return of(innerPost);
            })
        );
    }

    public dislikeComment(comment: Comment, currentUser: User) {
        const innerComment = comment;

        const reaction: NewDisReaction = {
            entityId: innerComment.id,
            isDisLike: true,
            userId: currentUser.id
        };

        // update current array instantly
        console.log(innerComment);
        let hasReaction = innerComment.disReactions.some((x) => x.user.id === currentUser.id);
        innerComment.disReactions = hasReaction
            ? innerComment.disReactions.filter((x) => x.user.id !== currentUser.id)
            : innerComment.disReactions.concat({ isDisLike: true, user: currentUser });
        hasReaction = innerComment.disReactions.some((x) => x.user.id === currentUser.id);

        return this.postService.dislikePost(reaction).pipe(
            map(() => innerComment),
            catchError(() => {
                // revert current array changes in case of any error
                innerComment.disReactions = hasReaction
                    ? innerComment.disReactions.filter((x) => x.user.id !== currentUser.id)
                    : innerComment.disReactions.concat({ isDisLike: true, user: currentUser });

                return of(innerComment);
            })
        );
    }
}