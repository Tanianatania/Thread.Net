import { User } from '../user';
import { Comment } from '../comment/comment';
import { Reaction } from '../reactions/reaction';
import { DisReaction } from '../disreaction/disReaction';

export interface Post {
    id: number;
    createdAt: Date;
    author: User;
    previewImage: string;
    body: string;
    comments: Comment[];
    reactions: Reaction[];
    disReactions: DisReaction[];
}
