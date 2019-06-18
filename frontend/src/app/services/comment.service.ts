import { Injectable } from '@angular/core';
import { HttpInternalService } from './http-internal.service';
import { NewComment } from '../models/comment/new-comment';
import { NewReaction } from '../models/reactions/newReaction';
import { NewDisReaction } from '../models/disreaction/newDisReaction';
import { Comment } from '../models/comment/comment';

@Injectable({ providedIn: 'root' })
export class CommentService {
    public routePrefix = '/api/comments';

    constructor(private httpService: HttpInternalService) { }

    public createComment(post: NewComment) {
        return this.httpService.postFullRequest<Comment>(`${this.routePrefix}`, post);
    }

    public likeComment(reaction: NewReaction) {
        return this.httpService.postFullRequest<Comment>(`${this.routePrefix}/like`, reaction);
    }
}
