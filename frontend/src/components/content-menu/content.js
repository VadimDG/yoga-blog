import React from 'react';
import './content.scss';
import { ContentMenuButton } from './button';

export function Content() {
    return (
        <div className="main-content">
            <div className="upper-menu">
                <ContentMenuButton name="about" />                
                <ContentMenuButton name="write" />
                <ContentMenuButton name="contact" />
                <ContentMenuButton name="shop" />
            </div>
        </div>
    );
}